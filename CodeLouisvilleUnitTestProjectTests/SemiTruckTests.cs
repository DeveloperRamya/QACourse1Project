﻿using CodeLouisvilleUnitTestProject;
using FluentAssertions;
using FluentAssertions.Execution;

namespace CodeLouisvilleUnitTestProjectTests
{
    public class SemiTruckTests
    {
       

        public CargoItem name { get; private set; }
        public CargoItem Cargo { get; private set; }

        //Verify that the SemiTruck constructor creates a new SemiTruck
        //object which is also a Vehicle and has 18 wheels. Verify that the
        //Cargo property for the newly created SemiTruck is a List of
        //CargoItems which is empty, but not null.
        [Fact]
        public void NewSemiTruckIsAVehicleAndHas18TiresAndEmptyCargoTest()
        {
            //arrange
            SemiTruck semiTruck = new(18, 20, "Toyota", "Camry", 15);


            //act

            //assert
            _ = semiTruck.NumberOfTires.Should().Be(18);
               
            
        }

        //Verify that adding a CargoItem using LoadCargo does successfully add
        //that CargoItem to the Cargo. Confirm both the existence of the new
        //CargoItem in the Cargo and also that the count of Cargo increased to 1.
        [Fact]
        public void LoadCargoTest()
        {
            //arrange
            SemiTruck semiTruck = new(18, 20, "Toyota", "Camry", 15);
            //act
            semiTruck.LoadCargo(Cargo);
            //assert
            semiTruck. Cargo.Should().NotBeNull();
        }

        //Verify that unloading a  cargo item that is in the Cargo does
        //remove it from the Cargo and return the matching CargoItem
        [Fact]
        public void UnloadCargoWithValidCargoTest()
        {
            //arrange
            SemiTruck semiTruck = new(18, 20, "Toyota", "Camry", 15);
            //act

            //assert
            semiTruck.Cargo.Should().BeNull();
        }

        //Verify that attempting to unload a CargoItem that does not
        //appear in the Cargo throws a System.ArgumentException
        //[Fact]
       // public void UnloadCargoWithInvalidCargoTest()
        //{
            //arrange
          //  SemiTruck semiTruck = new(18, 20, "Toyota", "Camry", 15);
            //act
            //Action act = () => semiTruck.UnloadCargo(Cargo);
            //assert
            //act.Should().Throw<ArgumentException>();
        //}

        //Verify that getting cargo items by name returns all items
        //in Cargo with that name.
        [Fact]
        public void GetCargoItemsByNameWithValidName()
        {
            //arrange
            throw new NotImplementedException();
            //act

            //assert

        }

        //Verify that searching the Carto list for an item that does not
        //exist returns an empty list
        [Fact]
        public void GetCargoItemsByNameWithInvalidName()
        {
            //arrange
            throw new NotImplementedException();
            //act

            //assert

        }

        //Verify that searching the Cargo list by description for an item
        //that does exist returns all matched items that contain that description.
        [Fact]
        public void GetCargoItemsByPartialDescriptionWithValidDescription()
        {
            //arrange
            throw new NotImplementedException();
            //act

            //assert

        }

        //Verify that searching the Carto list by description for an item
        //that does not exist returns an empty list
        [Fact]
        public void GetCargoItemsByPartialDescriptionWithInvalidDescription()
        {
            //arrange
            throw new NotImplementedException();
            //act

            //assert

        }

        //Verify that the method returns the sum of all quantities of all
        //items in the Cargo
        [Fact]
        public void GetTotalNumberOfItemsReturnsSumOfAllQuantities()
        {
            //arrange
            throw new NotImplementedException();
            //act

            //assert

        }
    }
}
