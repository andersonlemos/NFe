using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace NFe.Helpers.Services
{
     public class Certificate
     {

       private  X509Store _store;
       private X509Certificate2Collection _certificates;
       private X509Certificate2Collection _certificatesCollection;  
  
       public Certificate()
       {
           CreateStoreLocation(new X509Store(StoreLocation.CurrentUser));
           StoreCertificates(this._store);
           FindCollections();
       }

       public Certificate(X509Store store)
       {
           CreateStoreLocation(store);
           StoreCertificates(this._store);
           FindCollections();
       }

       private void CreateStoreLocation(X509Store store)
       {
         _store = store;
         _store.Open(OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly);
       }

       private void StoreCertificates(X509Store store)
       {
           _certificates = store.Certificates;
       }

       private X509Certificate2Collection CertificatesFindByTimeValid(X509Certificate2Collection certificates)
       {
           return certificates.Find(X509FindType.FindByTimeValid, DateTime.Now, false);
       }

       private X509Certificate2Collection CertificatesFindByKeyUsage(X509Certificate2Collection certificates)
       {
           return certificates.Find(X509FindType.FindByKeyUsage, X509KeyUsageFlags.DigitalSignature, false);
       }
     
       private void FindCollections()
       {
           _certificatesCollection = CertificatesFindByKeyUsage(CertificatesFindByTimeValid(_certificates));
        }

       public X509Certificate2Collection GetCollection()
       {
      
         return _certificatesCollection;

       }

     }
}
