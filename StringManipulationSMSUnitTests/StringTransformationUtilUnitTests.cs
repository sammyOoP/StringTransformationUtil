using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using StringManipulationSMS;

namespace StringManipulationSMSUnitTests
{
    public class StringTransformationUtilUnitTests
    {
        private string textInput = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod"
            + " tempor incididunt ut labore et dolore magna aliqua. Tempus quam pellentesque nec nam."
            + " Eget aliquet nibh praesent tristique. Duis ultricies lacus sed turpis tincidunt id."
            + " Mauris pellentesque pulvinar pellentesque habitant morbi. Sed lectus vestibulum mattis"
            + " ullamcorper velit sed ullamcorper morbi tincidunt. Habitant morbi tristique senectus et"
            + " netus et malesuada fames. In arcu cursus euismod quis viverra nibh cras pulvinar mattis." 
            + " Enim lobortis scelerisque fermentum dui. Commodo sed egestas egestas fringilla phasellus" 
            + " faucibus. Nisl vel pretium lectus quam id. Nunc eget lorem dolor sed. Sit amet massa vitae" 
            + " tortor condimentum. Quis risus sed vulputate odio. Tristique risus nec feugiat in fermentum." 
            + " Eu scelerisque felis imperdiet proin fermentum leo vel. Nisi scelerisque eu ultrices vitae auctor eu.";

        [Fact]
        public void TransformInputIntoTextMessages_ShouldReturnNoMoreThan140Characters_WhenPassedAString()
        {
            //Arrange
            StringTransformationUtil _StringTransformationUtil = new StringTransformationUtil();
            int maxExpectedOutput = 140;

            //Act
            var results = _StringTransformationUtil.TransformInputIntoTextMessages(textInput);

            //Assert
            Assert.All(results, result => Assert.True(result.MessageText.ToString().Length < maxExpectedOutput));
        }
    }
}