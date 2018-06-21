
using Keys.Global;
using Keys.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Keys.Test
{
    class OnBoardingTask2
    {
        [TestFixture]
        class OnBoardingTask2Rupesh : Base
        {
            [Test]
            public void Dashboard_GoToOwnerPropertiesPage()
            {
                test = extent.StartTest("Owner can goto Properties Page");
                Dashboard dashboardObj = new Dashboard();
                dashboardObj.goToPropertiesPage();
                OwnerProperties ownerPropertiesObj = new OwnerProperties();
                ownerPropertiesObj.isOnOwnerPropertiesPage();
              

            }

            [Test]
            public void OwnerProperties_AddProperty()
            {
                test = extent.StartTest("Owner can Add A Property");
                Dashboard dashboardObj = new Dashboard();
                dashboardObj.goToPropertiesPage();

                int rowNumberAddProperty = 2;
                OwnerProperties ownerPropertiesObj = new OwnerProperties();
                ownerPropertiesObj.cLickOnAddAPropertyLink();
                AddNewPropertyPropertyDetails addNewPropertyPropertyDetailsObj = new AddNewPropertyPropertyDetails();
                addNewPropertyPropertyDetailsObj.fillPropertyDetails(rowNumberAddProperty);
                AddNewPropertyFinanceDetails addNewPropertyFinanceDetailsObj = new AddNewPropertyFinanceDetails();
                addNewPropertyFinanceDetailsObj.fillFinanceDetails(rowNumberAddProperty);
                ownerPropertiesObj.isOnOwnerPropertiesPage();
                ownerPropertiesObj.searchProperty(addNewPropertyPropertyDetailsObj.nameOfAddedProperty(rowNumberAddProperty));
                ownerPropertiesObj.comparePropertiesForAddAProperty(rowNumberAddProperty);
               
  
            }

            [Test]
            public void OwnerProperties_SearchProperty_ListAsRental()
            {
                test = extent.StartTest("Owner can list a particular property as rental");
                Dashboard dashboardObj = new Dashboard();
                dashboardObj.goToPropertiesPage();

                int rowNumberAddProperty = 3;
                int rowNumberListAsRental = 2;
                OwnerProperties ownerPropertiesObj = new OwnerProperties();
                ownerPropertiesObj.cLickOnAddAPropertyLink();
                AddNewPropertyPropertyDetails addNewPropertyPropertyDetailsObj = new AddNewPropertyPropertyDetails();
                addNewPropertyPropertyDetailsObj.fillPropertyDetails(rowNumberAddProperty);
                AddNewPropertyFinanceDetails addNewPropertyFinanceDetailsObj = new AddNewPropertyFinanceDetails();
                addNewPropertyFinanceDetailsObj.fillFinanceDetails(rowNumberAddProperty);
                ownerPropertiesObj.isOnOwnerPropertiesPage();
                ownerPropertiesObj.searchProperty(addNewPropertyPropertyDetailsObj.nameOfAddedProperty(rowNumberAddProperty));
                ownerPropertiesObj.comparePropertiesForAddAProperty(rowNumberAddProperty);

                ownerPropertiesObj.clickOnListAsRentalLink();
                ParticularPropertyListAsRental particularPropertyListAsRentalObj = new ParticularPropertyListAsRental();
                string addressOfListedProperty = particularPropertyListAsRentalObj.addressOfListedProperty(rowNumberListAsRental);
                particularPropertyListAsRentalObj.fillListAsRentaldetails(rowNumberListAsRental);
                
                OwnerRentalProperties ownerRentalPropertiesObj = new OwnerRentalProperties();
                ownerRentalPropertiesObj.isOnOwnerRentalPropertiesPage();
                ownerRentalPropertiesObj.searchProperty(particularPropertyListAsRentalObj.titleOfListedProperty(rowNumberListAsRental));
                ownerRentalPropertiesObj.selectfromSortByDropdown("Latest Date");
                ownerRentalPropertiesObj.comparePropertiesForListAsRental(addressOfListedProperty);
              

            }

            [Test]
            public void OwnerProperties_NavigationBar()
            {
                test = extent.StartTest("Owner can goto Last Page and Back to first Page on Properties Page");
                Dashboard dashboardObj = new Dashboard();
                dashboardObj.goToPropertiesPage();

                OwnerProperties ownerPropertiesObj = new OwnerProperties();
                int totalNumberOfPages = ownerPropertiesObj.totalNumberOfPages();
                ownerPropertiesObj.gotoLastPage(totalNumberOfPages);
                ownerPropertiesObj.checkIfOnLastPage(totalNumberOfPages);
                ownerPropertiesObj.goBackToFirstPage(totalNumberOfPages);
                ownerPropertiesObj.checkIfOnFirstPage();
                
                 
                
            }
        }
    }
}
