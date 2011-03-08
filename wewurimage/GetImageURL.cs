using System;
using System.Text.RegularExpressions;

namespace wewurimage {
    partial class Account {
        private string GetImageURL(string _account_URL) {
            String _userdata;
            
            // Fetch data from wewur user page
            _userdata = WebFetch(_account_URL);
            
            // Extract the image URL
            Regex regx = new Regex("http://.*wbafoto.*jpg", RegexOptions.IgnoreCase);
            MatchCollection matches = regx.Matches(_userdata);
            
            // If there is an URL, return that, else return null
            // Silent fail if there are more than one matches
            if (matches.Count == 1) {
                return matches[0].Value;
            }
            else {
                return null;
            }
        }
    }
}
