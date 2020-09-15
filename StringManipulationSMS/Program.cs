using System;

namespace StringManipulationSMS
{
    class Program
    {
        static void Main(string[] args)
        {
            string textInput = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod"
            + " tempor incididunt ut labore et dolore magna aliqua. Tempus quam pellentesque nec nam."
            + " Eget aliquet nibh praesent tristique. Duis ultricies lacus sed turpis tincidunt id."
            + " Mauris pellentesque pulvinar pellentesque habitant morbi. Sed lectus vestibulum mattis"
            + " ullamcorper velit sed ullamcorper morbi tincidunt. Habitant morbi tristique senectus et"
            + " netus et malesuada fames. In arcu cursus euismod quis viverra nibh cras pulvinar mattis." 
            + " Enim lobortis scelerisque fermentum dui. Commodo sed egestas egestas fringilla phasellus" 
            + " faucibus. Nisl vel pretium lectus quam id. Nunc eget lorem dolor sed. Sit amet massa vitae" 
            + " tortor condimentum. Quis risus sed vulputate odio. Tristique risus nec feugiat in fermentum." 
            + " Eu scelerisque felis imperdiet proin fermentum leo vel. Nisi scelerisque eu ultrices vitae auctor eu.";

            StringTransformationUtil Util = new StringTransformationUtil();

            var messages = Util.TransformInputIntoTextMessages(textInput);

            foreach (TextMessage message in messages)
            {
                Console.WriteLine(message.MessageText);
            }
        }
    }
}
