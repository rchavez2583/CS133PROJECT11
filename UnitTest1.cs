using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyUnitTESTPROJECT11
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CanUserBeAttacked_IfItsAPointer_ReturnsTrue()
        {
            //Arrange
            MyClass class = new MyClass();


        User newUser = new User();
        newUser.IsPointer = true;
           newUser.UserName = "Rene";

            Clan newClan = new Clan();
        newClan.ClanName = "Soluctions";
            newUser.ClanInfo = newClan;
            class.CurrentUser = newUser;
            //Act
            
            User newUser = new User();
        newUser.IsPointer = true;
              newUser.UserName = "Jonh Doe";

            Clan newUserClan = new Clan();
        newUserClan.ClanName = "SU guys"

            newUser.ClanInfo
            bool canItBeAPointer = class.CanUserBeAttacked();

        //Assert
        Assert.ItTrue(canItBeAPointer);
         }
    }

}

             