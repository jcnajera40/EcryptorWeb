using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace EcryptorWeb.Models
{

    public class CDownloadRequest { 
        private Guid requestGUID;
        private string downloadFileName;
       
        public CDownloadRequest()
        {
            this.requestGUID = Guid.NewGuid();
            this.downloadFileName = this.requestGUID.ToString() + ".zip";
        }
        public Guid RequestID
        {
            get { return this.requestGUID; }
        }
        public string DownloadFileName
        {
            get { return this.downloadFileName; }
            set { this.downloadFileName = value; }
        }
        public Dictionary<string, CloudBlockBlob> BlobCollection { get; set; }
    }
}

