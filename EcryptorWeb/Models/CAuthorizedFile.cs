using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace EcryptorWeb.Models
{
    public class CAuthorizedFile
    {
        private CloudBlockBlob _file;
        private Guid _requestGUID;
        private string _userUpn;
        private string _originalFileName;
        private string _internalFileName;
        private string _uri;
        private DateTimeOffset _adhocPolicyDueDate;
        private DateTimeOffset _lastModifiedDate;
        private int _id;
        // public static int ObjectNumber=0 ;

        public CAuthorizedFile(CloudBlockBlob blobObject, int sequence)
        {
            _file = blobObject;
            string[] fnparts = _file.Name.Split('_');

            if (fnparts.Length == 3)
            {
                this._userUpn = fnparts[2];
                this._requestGUID = Guid.Parse(fnparts[1]);
                this._internalFileName = _file.Name;
                this._originalFileName = fnparts[0].Replace("-", " ");
                this._id = sequence;
                this._lastModifiedDate = this._file.Properties.LastModified.Value;
                this._adhocPolicyDueDate = this._file.Properties.LastModified.Value.AddDays(7);
                this._uri = blobObject.Uri.AbsoluteUri;
            }
        }

        public Guid RequestID
        {
            get { return this._requestGUID; }
        }
        public string OriginalFileName
        {
            get { return this._originalFileName; }
        }
        public int Id
        {
            get { return this._id; }
        }
        public string InternalFileName {
            get { return this._internalFileName; }
        }
        public string URI {
            get { return this._uri; }
        }
        public long Size {
            get { return this._file.Properties.Length; }
        }
        public string SizeFormated
        {
            get {

                long bSize = this._file.Properties.Length;
                string metric = "b";
                long xSize = bSize;

                switch (bSize)
                {
                    case long bsize when (bSize < 1024):
                        metric = "b";
                        xSize = bSize;
                        break;
                    case long bsize when ((bSize / 1024) < 1024):
                        metric = "Kb";
                        xSize = (bSize / 1024);
                        break;
                    case long bsize when (((bSize / 1024) / 1024) < 1024):
                        metric = "Mb";
                        xSize = ((bSize / 1024) / 1024);
                        break;
                    case long bsize when ((((bSize / 1024) / 1024) / 1024) < 1024):
                        metric = "Gb";
                        xSize = (((bSize / 1024) / 1024) / 1024);
                        break;
                    case long bsize when (((((bSize / 1024) / 1024) / 1024) / 1024) < 1024):
                        metric = "Tb";
                        xSize = ((((bSize / 1024) / 1024) / 1024) / 1024);
                        break;
                }
                return xSize.ToString(format: "### ### ### ###").TrimStart() + metric;
            }
        }
        public string Requestor
        {
            get { return this._userUpn; }
        }
        public DateTimeOffset LastChangeDateTime {
            get { return (DateTimeOffset)this._file.Properties.LastModified; }
        }

        public DateTimeOffset PolicyDueDate
        {
            get { return (DateTimeOffset)this._adhocPolicyDueDate; }
        }
        public int AdhocPolicyRemainingDays{
            get { return ((TimeSpan)(this._adhocPolicyDueDate - this._lastModifiedDate)).Days; }
}
        public String DocumentGrantedRights
        {
            get { return string.Empty; }
        }
    }
}
