﻿using NFe.Helpers.Interfaces;
using System.IO;

namespace NFe.Helpers.Services
{
    public class SaveDocument:ISaveOperation
    {
      private object _document;
      private string _fileName;
      private StreamWriter _streamWriter;
      private FileInfo _fileInfo;

      private FileInfo fileInfo
      {
          get { if (_fileInfo == null) return new FileInfo(_fileName);
          return _fileInfo;
          }
      }

      public SaveDocument()
      {
      }

      public SaveDocument(object document,string fileName)
      {
        this._document = document;
        this._fileName = fileName;
      }

      public bool WasSaved()
        {
           try
            {
                SaveToFile();
                return true;
            }
            catch 
            {
              
                return false;
            }
        }

        public void SaveToFile()
        {
           
            _streamWriter = null;

            try
            {
                _streamWriter = fileInfo.CreateText();
                _streamWriter.WriteLine((string)this._document);
                _streamWriter.Close();
            }
            finally
            {
                if ((((_streamWriter) != null)))
                {
                    _streamWriter.Dispose();
                }
            }
        }

    }
}
