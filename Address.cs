using System;

namespace C_sharp_core
{
    class Address
{
    private string roadNo;
    private string houseNo;
    private string city;
    private string country;
    public Address(string roadNo, string houseNo, string city, string country)
    {
        this.country = country;
        this.houseNo = houseNo;
        this.city = city;
        this.roadNo = roadNo;
    }
    public String GetAddress()
    {
        return "Address is => " + "Road No: " + roadNo + ", House No: " + houseNo + ", City: " + city + ", Country: " + country;
    }

}
 
 
}
