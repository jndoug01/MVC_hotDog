using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_hotDog_NathanDougherty.Models
{
    public class Service
    {

    private static List<hotDogLover> hotDogLovers;
    static Service() {
    hotDogLovers = populatehotDogLovers();
                 }
    public void resetService() {
hotDogLovers = populateHotDogLovers();
}

    private List<hotDogLover> populateHotDogLovers()
    {
        List<hotDogLover> hotDogLovers = new List<hotDogLover>();

        hotDogLover hdl1 = new hotDogLover();
        hdl1.Name = "bob";
        hdl1.Bio = "I like hot dogs";
        hdl1.FavoriteDog = "beef";
        hdl1.lastAte = "pork";
        hotDogLover hdl2 = new hotDogLover();
        hdl2.Name = "joe";
        hdl2.Bio = "I like turtles";

        return hotDogLovers;
    }
public List<hotDogLover> getHdl() {
return hotDogLovers;
}
public void updateStudent(hotDogLover hotDogLover) {
removeHotDogLover(hotDogLover);
addHotDogLover(hotDogLover);
}

private void addHotDogLover(hotDogLover hdl)
{
    if (!string.IsNullOrWhiteSpace(hdl.Name))
    {

        foreach (hotDogLover hotDogLover in hotDogLovers)
        {
            hotDogLovers.Add(hotDogLover);
        }
    }
}

private void removeHotDogLover(hotDogLover hdl)
{
    hotDogLover hotDogLover = getName(hdl.Name);
    hotDogLovers.Remove(hotDogLover);
}
public hotDogLover getName(string aName) {
hotDogLover foundhotDogLover = new hotDogLover();
foreach (hotDogLover hdl in hotDogLovers) {
if (hdl.Name==aName) {
foundhotDogLover = hdl;
}

}
return foundhotDogLover;
}
public void removehotDogLover(hotDogLover hdl)
{
hotDogLover hotDogLover = getName(hdl.Name);
hotDogLovers.Remove(hotDogLover);
}
public void addhotDogLover(hotDogLover hdl)
{
    if (!string.IsNullOrWhiteSpace(hdl.Name))
    {

        foreach (hotDogLover hotDogLover in hotDogLovers)
        {
            hotDogLovers.Add(hotDogLover);
        }
    }
}
private static List<hotDogLover> populatehotDogLovers()
{
List<hotDogLover> hotDogLovers = new List<hotDogLover>();

    hotDogLover hdl1 = new hotDogLover();
    hdl1.Name = "bob";
    hdl1.Bio = "I like hot dogs";
    hdl1.FavoriteDog = "beef";
    hdl1.lastAte = "pork";
    hotDogLover hdl2 = new hotDogLover();
    hdl2.Name = "joe";
    hdl2.Bio = "I like turtles";

return hotDogLovers;
}

}
    }
