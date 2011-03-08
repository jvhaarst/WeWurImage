using System;
using System.Drawing;

namespace wewurimage {
    partial class Account {
        private string _account;
        private Bitmap _accountPicture;
        private string _wewurURL = "http://www.wewur.wur.nl/popups/vcard.aspx?id=";

        public string AccountName {
            get { return _account; }
            set { _account = value; }
        }

        public Bitmap AccountPicture {
            get {
                String _imageURL;
                // To Do : dit omschrijven zodat er nog maar 1 method voor nodig is.
                _imageURL = GetImageURL(_wewurURL + AccountName);
                _accountPicture = (Bitmap)GetImage(_imageURL);
                return _accountPicture;
            }
            set { _accountPicture = value; }
        }
    }
}
