namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The company might employ something known as object-oriented analysis and design which describes a formal methodology to creating a formal design");
            Console.WriteLine("Typically in object-oriented analysis and design the business analysts and software architects would spend a lot of time designing the software on paper");
            Console.WriteLine("That design might include some very specific things like the design of individual classes, the property names,the methods even what values should be passed into a given method");
            Console.WriteLine("They may create design that actualy talk about the interactions between the various objects in the system.Where are the objects ? What property and what's object and how do we know whne it should interact and what responsability should we give it ");
            Console.WriteLine("Typically in software tool that allows the analysts and the designers the software architects to collect and organize their analysis and their design all in on collaborative space");
            Console.WriteLine();
            Console.WriteLine("Two decades ago analysis and design was expressed in UML - unified modeling language and it was mostly visual language of boxes, stick figures and lines and arrow heads");
            Console.WriteLine("They will use those different combinations throught a number of different documents that were output called artifacts. ");
            Console.WriteLine("Those artifacts would present different facets of design of the system. ");
            Console.WriteLine("There was use case  and it outlined what's called a basic course of events . The tipical steps that a user and system would go throught. Like use case for ATM");
            Console.WriteLine("It would also outline variuos edge cases like what happens if the user enters the wrong code, or ATM does not have enought money");
            Console.WriteLine("Some artifacts were more focused on analysis speaking in very broad generalizes terms, some were more focused on design speaking in more system specific or technology specific terms");
            Console.WriteLine("It will require months and months to flush out the entire system using this modeling language documenting the requirements to this degree");
            Console.WriteLine();
            Console.WriteLine("Big design up front");
            Console.WriteLine("The design only take into account what i wolud call the happy path, the most likely scenario. It did not count for all the edge cases.  ");
            Console.WriteLine("80 % of our code is there to address 20 % of all problems, or all edge cases. ");
            Console.WriteLine("In some cases, edge cases required a rethinking of entire design");
            Console.WriteLine("From a business perpective, the guy knew what he was doing, but he wasn't technical. He didn't realize the contraints of a system, especially in that case in regards to persistence");
            Console.WriteLine("The developers were often left to just go and figure it out on their own");
            Console.WriteLine("The developers were completely abstracted away from domain exprerts that were initially consulted during the design and analyst phase. So whenever a question about the design popped up, one of the developers not quite sure what they shoud do");
            Console.WriteLine("In this scenario, they may have to go thought several layers of designers and analysts to get a simple question answered");
            Console.WriteLine("Like change, time is also one of the sworn enemies of the software developers because software development is all about especially in a team environment, it is all about collaboration and communication");
            Console.WriteLine("The 3 issue with big design up front, it took forever to build an application this way");
            Console.WriteLine("In the course of 3 to 6 months  the business needs would often change. ");
            Console.WriteLine("So while designer is designing the application, the bussines is going busseins. By the time he finishes his design and he throws it over to the wall to the software developers");
            Console.WriteLine("The bussines could be changing completely under him. Now the developers have the design of the system in hand, printed on the screen and they are going throught it ,and it might not be true anymore ");
            Console.WriteLine("This will often cause fundamental changes to the way that software was built. The design documentation does not have any accountg for this new way and now we are throwing out the documentation completely");
            Console.WriteLine("This give us a reason number 4 why Big design up front was bad idea . When the design was no longer relevant because of its inheritent flaws or because the bussiness funadamentally changed");
            Console.WriteLine("THe codified version of the design became obsolete and useless and pretty much  a waste. ");
            Console.WriteLine("You eather had to work hard to keep the design documentation in line with the current state of the bussiness and the current state of the software. ");
            Console.WriteLine("The fifth  problem with big design up front was unclear exacly how far along the developers were in the software development project");
            Console.WriteLine("The problem with that strategy was the developers did not really understand then the breath of the application scope. Theyt only had what was immidiately in front of them");
            Console.WriteLine("Number 6 they worked for weeks at a time on a giver feature, but that might not inclued user interfgace because after all the unser interface inst all that important");
            Console.WriteLine("They were cretating a domain layer to the exclusion to everyting else. Meaning that they had no way to prove that the sotware was working ");
            Console.WriteLine("And now the critics come out, this was not what we wanted etc ");

            Console.ReadLine();


            
        }
    }
}

// https://www.youtube.com/watch?v=h5VImJJd_qI&list=PLqT8wAi-pOx7X3i6Vynm57MCwFpQWJdP9&index=4