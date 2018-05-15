using System;
using System.Collections.Generic;

namespace EcryptorWeb.Helpers
{
    public class EcryptorResponse
    {
      
        public EcryptorResponse(Guid ecryptorRequestRowid)
        {
            EcryptorRequestRowid = ecryptorRequestRowid;
            UploadedFiles = new List<string>();
        }

        public Guid EcryptorRequestRowid { get; set; }
        public string UserRequestorUpn { get; set; }
        public string UserCountry { get; set; }
        public string UserRegion { get; set; }
        public string UserCity { get; set; }
        public string UserDpto { get; set; }
        public string UserJob { get; set; }
        public string UserManager { get; set; }

        public string ResquestStatus { get; set; }
        public string RequestorNotes { get; set; }
        public bool RequestIsActive { get; set; }
        public string CreationDate { get; set; }
        public List<string> UploadedFiles { get; set; }
    }
}
