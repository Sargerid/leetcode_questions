public class Solution {
    public string DefangIPaddr(string address) {
    address.Replace( ".", "[.]");
    string b = address.Replace(".", "[.]");
    return b;    
    }
}
