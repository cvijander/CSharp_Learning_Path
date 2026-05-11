using System.Runtime.ConstrainedExecution;

namespace ThinkingLikeAnOOPConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // ChooseToDisplayMainMenu();


            string lessionText = @"1. Classes, Objects, Properties, Methods
2. Private, Public, Static, Instance 
3. Inheritance, Abstract, Intefface 
4. Object BASED Programming 


Object oriented programming transcend code in so much that it transcends any give programming language per se 
OO is a mindset 
A philosophy which drives a way of thinking 
A world view about problems and solutions 
A path with a North star 
Guidance and principles on how to achieve overarching objectives 
Object-oriented programming provides a process on how to discover and implement a conceptual machine to realize that desired output.
How to decompose a problem in the real world and then build some sort of abstraction in this etherial world in our minds.
Abstraction of that real world problem, and than we will build that abstraction using principles,patterns , that will actually sum up important tenants of object-oriented programming.
Then the end result is that we have designed conceptually designed machine that takes raw materials like data input from the user, and converts those into thinks like data that has been processed,mesaging, activities and so on
Those will have meaning in the living world, even if that is a conceptual world like the account world
Software dev religion
In other worlds , ita age old wisdom - not a rulebook - that gives you guidance that you must apply situactionally for your specific problem domain.
Require devotion
People devote their entire careers practicing and learning more about Object Orientation and how to apply it in a give situation


";
                        Lession IntroMainPage = new Lession(1, "Intro in  OOP", lessionText);

                        IntroMainPage.DisplayLession();
            

        }

        public static void MainPage()
        {
            Console.Clear();
            Console.WriteLine();
           // Console.WriteLine("1. Classes, Objects, Properties, Methods");
           // Console.WriteLine("2. Private, Public, Static, Instance ");
           // Console.WriteLine("3. Inheritance, Abstract, Intefface");
          //  Console.WriteLine("4. Object BASED Programming");
            Console.WriteLine();



            Console.WriteLine();
           //Console.WriteLine("Object oriented programming transcend code in so much that it transcends any give programming language per se");
            Console.WriteLine();

          //  Console.WriteLine("OO is a mindset");
          //  Console.WriteLine("A philosophy which drives a way of thinking");
          //  Console.WriteLine("A world view about problems and solutions");
          //  Console.WriteLine("A path with a North star");
          //  Console.WriteLine("Guidance and principles on how to achieve overarching objectives");
            Console.WriteLine();


            Console.WriteLine();
           // Console.WriteLine("Object-oriented programming provides a process on how to discover and implement a conceptual machine to realize that desired output.");
           // Console.WriteLine("How to decompose a problem in the real world and then build some sort of abstraction in this etherial world in our minds. ");
           // Console.WriteLine("Abstraction of that real world problem, and than we will build that abstraction using principles,patterns , that will actually sum up important tenants of object-oriented programming. ");
           // Console.WriteLine("Then the end result is that we have designed conceptually designed machine that takes raw materials like data input from the user, and converts those into thinks like data that has been processed,mesaging, activities and so on");
           // Console.WriteLine("Those will have meaning in the living world, even if that is a conceptual world like the account world");
            Console.WriteLine();


            Console.WriteLine();
           // Console.WriteLine("Software dev religion");
          //  Console.WriteLine("In other worlds , ita age old wisdom - not a rulebook - that gives you guidance that you must apply situactionally for your specific problem domain.");

            Console.WriteLine();
            //Console.WriteLine("Require devotion");
           // Console.WriteLine("People devote their entire careers practicing and learning more about Object Orientation and how to apply it in a give situation");
            Console.WriteLine();


            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Goals");
            Console.WriteLine("1. Improve Modularity");
            Console.WriteLine("2. Improve process of Analysis, a Design and Communication of a Problem Domain and a Software Solution");
            Console.ResetColor();
            Console.WriteLine();


            Console.WriteLine("Modularity");
            Console.WriteLine();
            Console.WriteLine("Goal is to incease code modularity");
            Console.WriteLine("\"A change in one module shouldn't break things in other modules\"");
            Console.WriteLine("Improve code maintance, adding or removing features will not break the entire application. It allows us to withstand the impact of change");
            Console.WriteLine("It allows us to build new features, and to make changes to existing features faster and more reliably");
            Console.WriteLine("Enable code reuse");
            Console.WriteLine("* Code Maintenance - adding or removing features, \"change\", faster, more reliably");
            Console.WriteLine("* Enable Code Re-user - packageable and re-useable");
            Console.WriteLine("* Enable Team Collaboration - code broken up into small bits that many can work on, specialists");
            Console.WriteLine("* Enable easier integration - easily abstract and isolate large systems so they can be intechanged");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("2. Improve process of analysis, a Design and Communication of a Problem Domain and a Software Solution");
            Console.WriteLine();
            Console.WriteLine("* Improving the process of breaking down a problem domain and designing a candidate solution and communiaction it to others.");
            Console.WriteLine();
            Console.WriteLine("Using this techiques, these ideas, we begin to look for boundaries in the system and look for the needs and responsabilities");
            Console.WriteLine("Look for a major players are in the system. It also provides a method of decomposition of a problem into smaller pieces.");
            Console.WriteLine("Now once we have identified the major players, and we have kind of begin to give them responsabilities .");
            Console.WriteLine("Here is a need in a system, who should be responsible for it  - further decomposotion of the system into delegating the responsobilities to a given method inside an object. ");

            PressEnterForMainMenu();
            
        }

        public static void EstablishingCrucialMetaphors()
        {
            Console.Clear();
            
            Console.WriteLine("Book - Object design - roles, responsabilities and collaborations by Rebecca Wars Brock and Alan McKeen. ");
            Console.WriteLine("It is widely regarded as probably one of the best works that captures the philosophy and the heart of object-oriented analysis, design and programming ");
            Console.WriteLine();
            Console.WriteLine("Object machinery - chapter 1");
            Console.WriteLine("All but the simplest of devices, both hardware and software, are designed from parts. These parts interact according to someone's plan.");
            Console.WriteLine("In a physical machine, these parts touch one another or communicate throught a shared medium. Their interactions may give way to force, transfer motion, or conduct heat");
            Console.WriteLine();
            Console.WriteLine("Software machinery is similar to physical machinery. A software application is constructed from parts. These parts -- software objects -- interact by sending messages to request information or action from others");
            Console.WriteLine("Throughout its lifetime, each object remains reponsible for respoding to a fixed set of requests. To fulfill these request, objects encapsulate scripted responses and the information that they base them on");
            Console.WriteLine("If an object is designed to remember certain facts, it can use them to respond differently to future requests.");
            Console.WriteLine();
            Console.WriteLine("So how do we invent these software machines? ");
            Console.WriteLine();
            Console.WriteLine("Building an object-oriented application means inventing appropriate machinery. We represent real-world information, processes, interactions, relationships");
            Console.WriteLine("Even error by inventing objects that don't exists in the real world");
            Console.WriteLine("We give life and inteligence to inanimate things. We take difficult-to-comprehend real-world objects and split them into simpler, more manageable software ones.");
            Console.WriteLine("We invent new objects");
            Console.WriteLine("Each has a specific role to play in the application. Our measure of success lies in how clearly we invent a software reality that satisfies our application's requirements - and not in how closely it resembles the real wolrd");
            Console.WriteLine("Because they have machine-like behaviours and because they can be plugged together to work in concert, object can be used to build very complex machines");
            Console.WriteLine("To manage this complexity, we divvy the system's behaviours into objects that play well-defined roles. If we keep our focus on the behaviour, we can design the application using several complementaty perspectives:");

            Console.WriteLine("APPLICATION DESIGN");
            Console.WriteLine("Using several different complimentary perspectives");
            Console.WriteLine("PERSPECTIVE");
            Console.WriteLine("APPLICATION     ->   A set of interacting objects");
            Console.WriteLine("OBJECT          ->   An implementation of one or more roles");
            Console.WriteLine("ROLE            ->   A set of related responsabilities");
            Console.WriteLine("RESPONSABILITY  ->   An obligation to perform a task or know information");
            Console.WriteLine("COLLABORATION   ->   An interaction of object or roles (or both )");
            Console.WriteLine("CONTRACT        ->   An agreement outlining the terms of a collaboration");
            Console.WriteLine();

            Console.WriteLine("So how do we invent these software machines?");
            Console.WriteLine();
            Console.WriteLine("We invent new objects.");
            Console.WriteLine("Each has a specific role to play in the application.");
            Console.WriteLine("our measure of success lies in how clearly we invent a software reality that satisfies our application's requirements -- and not in how closely it resembles the real world");

            Console.WriteLine("CRUCIAL METAPHOR: SOFTWARE AS A FACTORY / MACHINE");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Think about a car factory (like General Motors).");
            Console.WriteLine("You start with raw materials. You have conveyor belts, presses, robotic arms.");
            Console.WriteLine("Each piece of machinery (Object) has a specific Responsibility.");
            Console.WriteLine("They must work in sync (Contracts/Collaborations) to produce a complex final product (the Car).");
            Console.WriteLine("Software is exactly the same! We design the machinery to accomplish the end result.");
            Console.WriteLine();



            Console.WriteLine("****************************************");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Preporucena literatura ");
            Console.ResetColor();
            Console.WriteLine("Object design - roles, responsabilities and collaboration");
            Console.WriteLine("Autori: Rebecca Wirst-Brock and Alan McKean");
            Console.WriteLine("****************************************");

            PressEnterForMainMenu();
            
        }

        public static void ApplicationLifecycleAndObjectOrientation()
        {
            Console.Clear();
            Console.WriteLine("Application lifecycle and object orientation");
            Console.WriteLine();
            Console.WriteLine("The principles and philosophies of object-oriented programming transcend the process of application development");
            Console.WriteLine("When I talk to about the process of application development, I 'm talking about thw primary approaches to the way that project is initiated and then managed");
            Console.WriteLine();
            Console.WriteLine("=== LESSON 3: The Business Side of Software ===");
            Console.WriteLine("The project starts way before the developers are even consulted or there is any initiacion with the developers.");
            Console.WriteLine();
            Console.WriteLine(" * In most organizations some need is identified");
            Console.WriteLine("Perhaps there is deficiency in a current business, or there is some new opportynity that's cropped up that the bussiness needs to take advantage of");
            Console.WriteLine();
            Console.WriteLine("As management tries to better understand the problem or the opportunity. They may get people involved who are called bussiness analysts");
            Console.WriteLine("Bussiness analyst are usually semi-technical people that are more focused on the bussiness side of the technology ");
            Console.WriteLine("They are interested in systems and  data flow and they are interested from a bussiness perspective");
            Console.WriteLine("They are usually asked upfront to compile the details in that of the opportunity or of the need into a set of requirements. ");
            Console.WriteLine("They can make a case to upper management on whether they should move forward and get budget allocated ");
            Console.WriteLine("These people are often referred to as the stakeholders who initiate this process because they have a vested interest in fixing the problem or pursuing the new opportunity");
            Console.WriteLine("Those that have most to gain and are going to be on the hook and the most fiscally responsible for the project are usually refered to as the project sponsors");
            Console.WriteLine();
            Console.WriteLine("As a part in this early process, the business analyst might even compile all the requirements into a documentation that's sent around to various vendors in the industry");
            Console.WriteLine("That documents is called  a request for information  - Here what we are looking at. Do you have something that can solve our problem? ");
            Console.WriteLine("They may even create a follw up document called a request for proposal, this will give more details and request and actual proposal and actual price ");
            Console.WriteLine("This process of gathering and talking and gathering can take months");
            Console.WriteLine("If the analyst can find a suitable software product or a system thatn will satisfy their requirment . So they may even decide that it is time to build that to buy a custom solution");
            Console.WriteLine();
            Console.WriteLine("Management has to decide to if tis worth time and the money to take this big project on");
            Console.WriteLine("They may need again to get a budget approved in the next fiscal year. That might require even more time spent upfront in analysis model.");
            Console.WriteLine("What are expected timelines for delivery? What human resources do we have available? Do we need to hire people? Do we need to bring in a third party people");
            Console.WriteLine("All these need to be determined long before the developers are brought to start ");
            Console.WriteLine("Now you get more and more people are involved in this process and there is a conversation going on throught a series of emails and meetings");
            Console.WriteLine("These people cuold be internal developers that are hired directly by the company employed by the company or they can be consultants that are representing software developments shops");




            Console.WriteLine("Before a programmer writes the first line of code, the business must make decisions.");
            Console.WriteLine("Software does not emerge in a vacuum; it solves a concrete business problem.");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("KEY ROLES AND PROJECT TERMS:");
            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine("1. Stakeholders / Project Sponsors:");
            Console.WriteLine("   People who have a vested interest in fixing the problem or pursuing the new opportunity. They fund the project.");
            Console.WriteLine();

            Console.WriteLine("2. Business Analyst (BA):");
            Console.WriteLine("   Semi-technical people focused on the business side of technology. They compile details into a set of 'Requirements'.");
            Console.WriteLine();

            Console.WriteLine("3. Subject Matter Expert (SME):");
            Console.WriteLine("   The practical expert who best understands the specific business domain and processes.");
            Console.WriteLine();

            Console.WriteLine("4. Requirements:");
            Console.WriteLine("   Specific details and needs that the software must fulfill to satisfy the business opportunity.");
            Console.WriteLine();

            Console.WriteLine("5. Build vs. Buy:");
            Console.WriteLine("   Management's decision whether to buy and customize an existing package, or build a custom solution.");
            Console.WriteLine();



            Console.WriteLine("CONCLUSION:");
            Console.WriteLine("The process employed during the early phases of an application's development life cycle");
            Console.WriteLine("can affect the success of the project as much or more than the philosophies of OOP.");
            Console.WriteLine();

            PressEnterForMainMenu();



        }

        public static void BigUpfrontDesign()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("LESSION 4  : OBJECT Oriented Analysis & DESIGN");
            Console.WriteLine("The company might employ something known as object-oriented analysis and design which describes a formal methodology to creating a formal design");
            Console.WriteLine("Typically in object-oriented analysis and design the business analysts and software architects would spend a lot of time designing the software on paper");
            Console.WriteLine("That design might include some very specific things like the design of individual classes, the property names,the methods even what values should be passed into a given method");
            Console.WriteLine("They may create design that actualy talk about the interactions between the various objects in the system.Where are the objects ? What property and what's object and how do we know whne it should interact and what responsability should we give it ");
            Console.WriteLine("Typically in software tool that allows the analysts and the designers the software architects to collect and organize their analysis and their design all in on collaborative space");
            Console.WriteLine();
            Console.WriteLine("Two decades ago analysis and design was expressed in UML - unified modeling language and it was mostly visual language of boxes, stick figures and lines and arrow heads");
            Console.WriteLine("They will use those different combinations throught a number of different documents that were output called artifacts. ");
            Console.WriteLine("Those artifacts would present different facets of design of the system. ");
            Console.WriteLine("There was use case  and it outlined what's called a basic course of events .The \"happy path \" The tipical steps that a user and system would go throught. Like use case for ATM");
            Console.WriteLine("It would also outline variuos edge cases like what happens if the user enters the wrong code, or ATM does not have enought money");
            Console.WriteLine("Some artifacts were more focused on analysis speaking in very broad generalizes terms, some were more focused on design speaking in more system specific or technology specific terms");
            Console.WriteLine("It will require months and months to flush out the entire system using this modeling language documenting the requirements to this degree");
            Console.WriteLine();
            Console.WriteLine("BIG DESIGN UP FRONT (BDUF) / WATERFALL METHODOLOGY - and why it failed");
            Console.WriteLine("1. The Happy Path Illusion: ");
            Console.WriteLine("The design only take into account what i would call the happy path, the most likely scenario. It did not count for all the edge cases.  ");
            Console.WriteLine("80 % of our code is there to address 20 % of all problems, or all edge cases. ");
            Console.WriteLine("In some cases, edge cases required a rethinking of entire design");
            Console.WriteLine();
            Console.WriteLine("2. Disconnected Developers:");
            Console.WriteLine("From a business perpective, the guy knew what he was doing, but he wasn't technical. He didn't realize the contraints of a system, especially in that case in regards to persistence");
            Console.WriteLine("The developers were often left to just go and figure it out on their own");
            Console.WriteLine("The developers were completely abstracted away from domain exprerts that were initially consulted during the design and analyst phase. So whenever a question about the design popped up, one of the developers not quite sure what they shoud do");
            Console.WriteLine("In this scenario, they may have to go thought several layers of designers and analysts to get a simple question answered");
            Console.WriteLine();
            Console.WriteLine("3. It took Forever (Business Chnaged)");
            Console.WriteLine("Like change, time is also one of the sworn enemies of the software developers because software development is all about especially in a team environment, it is all about collaboration and communication");
            Console.WriteLine("The 3 issue with big design up front, it took forever to build an application this way");
            Console.WriteLine("In the course of 3 to 6 months  the business needs would often change. ");
            Console.WriteLine();
            Console.WriteLine("4. Obsolute Documentation:");
            Console.WriteLine("So while designer is designing the application, the bussines is going busseins. By the time he finishes his design and he throws it over to the wall to the software developers");
            Console.WriteLine("The bussines could be changing completely under him. Now the developers have the design of the system in hand, printed on the screen and they are going throught it ,and it might not be true anymore ");
            Console.WriteLine("This will often cause fundamental changes to the way that software was built. The design documentation does not have any accountg for this new way and now we are throwing out the documentation completely");
            Console.WriteLine("This give us a reason number 4 why Big design up front was bad idea . When the design was no longer relevant because of its inheritent flaws or because the bussiness funadamentally changed");
            Console.WriteLine("THe codified version of the design became obsolete and useless and pretty much  a waste. ");
            Console.WriteLine("You eather had to work hard to keep the design documentation in line with the current state of the bussiness and the current state of the software. ");
            Console.WriteLine();
            Console.WriteLine("5. Unclear Progress:");
            Console.WriteLine("The fifth  problem with big design up front was unclear exacly how far along the developers were in the software development project");
            Console.WriteLine("The problem with that strategy was the developers did not really understand then the breath of the application scope. Theyt only had what was immidiately in front of them");
            Console.WriteLine();
            Console.WriteLine("6. No working Software to Demonstrate:");
            Console.WriteLine("Number 6 they worked for weeks at a time on a giver feature, but that might not inclued user interfgace because after all the unser interface inst all that important");
            Console.WriteLine("They were cretating a domain layer to the exclusion to everyting else. Meaning that they had no way to prove that the sotware was working ");
            Console.WriteLine("And now the critics come out, this was not what we wanted etc ");

            Console.WriteLine();
            Console.WriteLine("CONCLUSION:");
            Console.WriteLine("Developers were blamed for late software, but they were put in a position to fail.");
            Console.WriteLine("This sparked a massive revolt and a new movement in the late 90s...");

            PressEnterForMainMenu();
            
        }

        public static void AgileMethodology()
        {
            Console.Clear();
            Console.WriteLine("In late 1990 early 2000s som;ething called extreme programming XP began to pop up.");
            Console.WriteLine("It emerged as the anthithesisi to big design upfront");
            Console.WriteLine("Some of the most succesfull parts of extreme programming were extracted out");
            Console.WriteLine("Some of the ideas weere changed, and some of the proponents of extreme programming adopted a different name calling it now");
            Console.WriteLine("The Agile methodology");
            Console.WriteLine();
            Console.WriteLine("Some companies of today adopt some form of agile, whethere it is very strict form of agile or a looser form of agile.");
            Console.WriteLine("When you contract Agile to BDEF several things start to emerge as obvious departures from the old guard");
            Console.WriteLine("1. The development team was involved in the process of analysis and design much earlier in the whole process");
            Console.WriteLine("2. The domain experts , the people that the bussiness analysts would talk to to determine what the needs of the aplication weere, they would typically be from the actual department, or the department that would be impacted the most from the development of the software ");
            Console.WriteLine("They will be the one using the software, the end users of it, and they would join the software developers in the same team ");
            Console.WriteLine("3. When developers had questions they would get the answer immediately, or the y could raise the question tho the people that they knwe back in their old department that would know the answer to that particular question");
            Console.WriteLine("4. The development team would outline a series of iterations or the projects manageer woudl do series of iterations one week , two weeks iterations");
            Console.WriteLine("Really short period of time,relative to most iterations up to that point, they call them \"sprints\"");
            Console.WriteLine("THe bussiness analyst, the developers, the project manager, they all sit around , they would collect these requirements as they talk throught what the system shoudl do ");
            Console.WriteLine("They collect those requirements on a series of index cards and tht to keep them all scoped");
            Console.WriteLine("They will use those index cards with programmers to say how long do you think would need us to implement that particular feature .");
            Console.WriteLine("It will give the project manager and the analyst and maybe even the subject matter expert some idea of what the feature and they would come up with some time estimate");
            Console.WriteLine("Those estimates were taken and presented to the sterring commiette.");
            Console.WriteLine("Thet would say, first iteration we have this many hours and these are the tasks and how many hours they should take , which feature do you need implemented first");
            Console.WriteLine("This gave the management a better insight into where they were actually in the development process, how far ahead or behind they were. ");
            Console.WriteLine("That manages some informations about what challenges lie ahead, and they would talk about what hurdles need to be removed. ");
            Console.WriteLine("The project manager would use this as an opprtunity to kind of keep thie finger on the pulse of where the project was really at and where the challenges were and if the estimates were in fact correct");
            Console.WriteLine("The project manager now has a lot of data, he got lots of feedback from his team, he is able to keep a board that shows every task,who is responsible for it, how far it is along those are called ");
            Console.WriteLine("So in any point in time , in a very visible way throught large boards or software , they would know and be able to communicate exactly where the project status was at");
            Console.WriteLine("At the end of a day you had to come out witha working software.");
            Console.WriteLine("At the end of the iteration or the sprint, the software had to work and it had to be demonstable. It had to do something");
            Console.WriteLine("Hopefully all of the tasks that weere committed to were deployed and demonstable to the steering committee.");
            Console.WriteLine("Any changes can be address in much more sooner in the development process. And then once you finished that sprint you got the feedback, the process would start all over again");
            Console.WriteLine();
            Console.WriteLine("With the agile software development process , a lot of emphasisi is made on embracing change , constants refactoring ");
            Console.WriteLine("Unit testing really makes this possible to constantly check and make sure that any changes that you mande to the software does not break anything else.");
            Console.WriteLine("If it break something it happened in last lines of code, it can identify the issuess much more early in the process than waitinig to the very end of the project to do your testing.");

            PressEnterForMainMenu();

        }

        public static void TheProcessCanAffectTheDesign()
        {
            Console.Clear();           
            Console.WriteLine("How an object-oriented design is created because it is going to affect how we understand design");
            Console.WriteLine("The design is essentially complete before anyone begins to write code ");
            Console.WriteLine("You end up with massive design documentation and those documents because of how much there is. It is just difficult to comprehend");
            Console.WriteLine("Wrap your brain around and it potentially becomes outdated and obsolete before the end of the project.");
            Console.WriteLine("Design that look great on papar can be deficult to implement or have unintended consequnces");
            Console.WriteLine("BDUF design tends to be more brittle. It does not account for the invetabillity of change");
            Console.WriteLine("When change comes it potentially destroys weeks and months worth of work");
            Console.WriteLine();
            Console.WriteLine("Agile approach");
            Console.WriteLine(" but in more agile approach, the design is revealed in smaller, more digestible units of time and work in concerte with actual implemetnation of software");
            Console.WriteLine("And the benefit of that is it is happening while there 's still time to adjust the direction and we don't have to throw out ");
            Console.WriteLine("So the team worries about this week's iteration and keeps the design flexible knowing that change is going to come");
            Console.WriteLine("It builds change into the software development process treating it as an inevitabillity. It embraces the inevitability of change");
            Console.WriteLine();
            Console.WriteLine("In a more BDUF approach, design is done more way in advance on paper.It is codified in some alternative language, some alternative tool.  ");
            Console.WriteLine("Those alternative expressions of the design have to be maintained constantly in order for that design to remain relevent to the system.");
            Console.WriteLine("Much time and effort is spent in either keeping the design documents relative relevant or the more likely scenario is that the development team begins to distrust the design documentation because they no longer reflects the reality of the business needs");
            Console.WriteLine();
            Console.WriteLine("In an agile approach the is the design. It is the documentation of how business works today.");
            Console.WriteLine("It evolve quickly and the code that express the business rules of the business much must keep pace with it. ");
            Console.WriteLine();
            Console.WriteLine("In a more BDUF approach there is a distinct period of analysis, a period of design, and then period of development, and then period of testing ");
            Console.WriteLine("But in agile approach those lines are blured, all kind happens in the same time, in a more organic fashion. The design is discovered over time, andi it is less structured, more fluid process that blend analysis, design, implementation and testing");
            Console.WriteLine();
            Console.WriteLine("Who is doing the designing and when they are creating the design does have some impact on the ultimate design of the system. THe more design that happens without the involment of the developers means more brittle design and it becomes a huge risk in the project");
            Console.WriteLine();
            Console.WriteLine("Object oriented programming is about creating flexible interchangeable objects that decrease the complexity of implementation and decrease the resistance of the application to the effects of change");
            Console.WriteLine("it eases the maintenance of the system, makes it more resilient to the impact and the inevitability of change long term");

            PressEnterForMainMenu();
        }

        public static void AbstractingTheRealWorldIntoADomainModel()
        {
            Console.Clear();
            Console.WriteLine("Our measure of success lies in how clearly we invent a software reality that satisfies our application requirements - and not how closely it resembles the real world");
            Console.WriteLine();
            Console.WriteLine("Object  oriented programming models the real world and that is what makes it so powerful and so easy to learn and how you simplify the complex problems because you have a real world things that you want to model");
            Console.WriteLine("Then it is easy to model in etherleal conceptual world. ");
            Console.WriteLine("You want to model an animal, it has 4 legs, feet, eyes, mouth, nose, method - talk  , and it can derive dog from animal class, also an a  cat , etc ");
            Console.WriteLine("But you can override and specialize them with example speak, the dog and the cat speaks different ");
            Console.WriteLine();
            Console.WriteLine("But it is a lie - it is a kind of misnomer");
            Console.WriteLine("You dont model the real world necessarily. You create a model that satisfies your applications requirements");
            Console.WriteLine("We take an abstraction of the real world and we call out those details that are pertinent to our applications needs");
            Console.WriteLine("Example of a  car, we can model it in number different ways");
            Console.WriteLine("Are we modeling a caf from a factory persepctive, maybe from a car lot,or from aspect of a service station or repair facility. Maybe even and inventory parts ");
            Console.WriteLine("We are modeling a car from the context of a traffic simulator, maybe we are really modeling specific roads and bussiness and residental areas and speed limit , maybe we are modeling a car from a context of a self-driving car software");
            Console.WriteLine("You can see that even though there is a real world car, there are many different facets and abstractions of it. And the way that we model the car in our application will depend on our the need of our application");
            Console.WriteLine("We  abstract those facets out into a model that describes the primary areas of focus inside of our problem domain");
            Console.WriteLine("We are inventing the object machinery as the book would put it. That object machinery fills a much richer set of concepts that what a paper forme would at first glance require");
            Console.WriteLine("Object oriented programming is not relly about modeling the real world per se. ");
            Console.WriteLine("It's althought there  that may have beeon a convinient way to understand it from a highlevel perspective as you were getting started. It helped you undestand classes , methods, properties");
            Console.WriteLine("Object oriented programming is about abstracting the real world into a subset perhaps a superset of objects that we need to consider for a specific problem domain and haow to implement it as a software system.");
            Console.WriteLine("So in some cases those objects will be our own creatinon deerived from our imagination that don't have physical or real world equivalents");
            Console.WriteLine("We create these abstractions because we are building conceptual machines. Machines that address ethreal conceptual needs like process, state, display, validation, persistence ");

            PressEnterForMainMenu();

        }

        public static void EstablishingRolesAndDelegatingResponsabilities()
        {
            Console.Clear();
            Console.WriteLine("APPLICATION DESIGN");
            Console.WriteLine("Using several different complimentary perspectives");
            Console.WriteLine();
            Console.WriteLine("Application    - A set of interacting objects");
            Console.WriteLine("Object         - An implementation of one or more roles");
            Console.WriteLine("Role           - A set of related responsibilities");
            Console.WriteLine("Responsability - An obligation to perform a task or know information");
            Console.WriteLine("Collaboration  - An inraction of objects or roles (or both)");
            Console.WriteLine("Contract       - An agreement outlining the terms of collaboration");


            Console.WriteLine("Each object plays a role. It plays a part of larger conceptual machine");
            Console.WriteLine("We delegate one or more responsabilities to an object and it now has the obligation to  take care or that task or to hold that information");
            Console.WriteLine("We are depending on it to do its job, so that the machine as a whole can function correctly. If he does not do its job, then the machine will have an issue");
            Console.WriteLine("We have a need and we delegate the responsibilities to take care of that need to an object ");
            Console.WriteLine("Whenever we devise our conceptual machine, there might be several different objects. Perhaps i Should use terms classes when i am talking about object here");
            Console.WriteLine("There's several different classes or objects that that could do what we need in a given situation. Perhaps some are better suited than others in a certain situation");
            Console.WriteLine("There might be some interchangebility in the objects or rather the classes that we ll rely on to fill a specific role in our system");
            Console.WriteLine("We choose one, the one that's best suited for our specific need in given area of the system.We rely on it to do its job potentially milions of times without fail");
            Console.WriteLine("Now that object will play an inportant role in our conceptual machine in our system.");
            Console.WriteLine("An object should really be good at just doing a few things");
            Console.WriteLine("And the scope of its capabilities should be fairly narrow focused");
            Console.WriteLine("We might call a well designed very focused object highly cohesive because its entire construction ,its properties, its methods, its events. they are all focused on just accomplishing one little thing");
            Console.WriteLine("Coonversely if we had a single machine capable of taking on several different responsabilities on our assembly line, it sound great, but when we need to maintain that machine");
            Console.WriteLine("This is going to be more complex to fix it whenver its breaks.Is it flexible enought to do everything we will ever need in the future.");
            Console.WriteLine("Is it possible that we are limited ourselves and we are made it more difficult to take that one machine out of our factory and replace it with smaller more focused mashines because we rely on it to do so much fo us ");
            Console.WriteLine("We may describe that machine as low cohesion because it is doing all bu herself ");
            Console.WriteLine();
            Console.WriteLine("So in general in object-oriented programming we want to assign responsabilities to very focused objects that can do one thing and they do them very well");
            Console.WriteLine("That object will play an important role in the system. But if our needs ever change over time, it;s good to know that we can swap out a given object and give it its responsabilities to a similar but diffrenet object");
            Console.WriteLine("That can perform the same role and do the same responsabilities but just do it a little bit differenty- but have little impact on the overall operation of the conceptual system");
            Console.WriteLine("Liskoff substitution principle . The L in the acronym solid  ");
            Console.WriteLine("Perhaps the most important set of principles for modern day object oriented programming ");

            PressEnterForMainMenu();
        }

        public static void ContactInterfacesAndCollaboration()
        {
            Console.Clear();
            Console.WriteLine("Collaboration is the idea that objects work together to complete a task");
            Console.WriteLine("Each object has responsabilities and plays a role in the system and this necessitates that each object gets along well with others");
            Console.WriteLine("The way they collaborate is typically through the sending of messages back and forth");
            Console.WriteLine("What makes object oriented programming interesting and useful is mesaging, collaboration, conversations between objects to complete a task ");
            Console.WriteLine("Machine has no such inteligence to ask questions throught unknowns ");
            Console.WriteLine("All it knows is that it expects input in one form and creates output potentially in a different form");
            Console.WriteLine("If it does not get exactly what it needs withing a very narrow set of parameters, it stops");
            Console.WriteLine();
            Console.WriteLine("Now in object oriented programming you can think of a contract in one of several ways. ");
            Console.WriteLine("The first and the easiest way to think about contract , when we are thinking about objects and classes and properties is to thnik about method signature");
            Console.WriteLine("If you want me to do that task that method, then i am going to need this information fomr you and you can expect back from me this information");
            Console.WriteLine("I am going to expect these input parameters, and then when it s all said and done, i m going to return back to you a variable or an object of this type.");
            Console.WriteLine("Now, if i cant' figure it out, i will let you know, I will raise and exception");
            Console.WriteLine("This is how object can communicate to each other a contract is throught a method signature");
            Console.WriteLine();
            Console.WriteLine("There is a notion of interface ");
            Console.WriteLine("This is a  special progammatic construct that defines a set of properties and methods and eventis and son that  a class must implement in order to take on a given task");
            Console.WriteLine("If you think about method signature and an interface over time you will begin to realize that they are two sides of the same coins");
            Console.WriteLine("The name that was attributed to this interface. It starts with the letter I by convention, also by convention it uses the suffix \"able\"");
            Console.WriteLine("Third ,there is two sides to a contract and then there is the contract itself . On the one side, you have an object that knows how to work with an object that implements I equitable");
            Console.WriteLine("On the other side you have the object that actually does the implementing. It actually implements IEquable");
            Console.WriteLine("In order to implement this interface this contract of I equatable it is implementing a method called equals , but there is not method body ");
            Console.WriteLine("All we are saying is that there has to be an implementation of this equals method, it has to return a boolean. It has to accept the type of T, whatever the T is of given object, ");
            Console.WriteLine("In order for this to be a class that implements I euatable");

            Console.WriteLine("\"No man is an island \"");
            Console.WriteLine("When you think of object you shoudl be thinking in those terms as well. Each object has responsabilities in its conceptual society and it has to collaborate with other objects in order to perform work");
            Console.WriteLine("In order to collaborate there has to be some sort of contract upfront, in the conceptual world this takes the form of method signatures");
            Console.WriteLine("It also take the form of interfaces");
            Console.WriteLine("We have defined a contract, we implemented a contract, and then we called a method ");
            Console.WriteLine("We are not worried about how it is implemented, just the fact thet if we need this functionality, then we have to make sure that we are relying on this interface");
            Console.WriteLine("And then the consumer and the implementer of that interface can work together, can collaborate, can excange messages");

            PressEnterForMainMenu();
        }

        public static void CollaborationsAndObjectRoleStereotypes()
        {

            Console.Clear();
           
            Console.WriteLine("A well defined object supports a clearly defined role in our system.");
            Console.WriteLine("Design is an iterative and incremental process of envisioning objects and their responsabilities and then inventing flexible collaborations between objects to carry those out");
            Console.WriteLine("When it comes to collaboration like we said, there are at least two parties involved ");
            Console.WriteLine("Two objects collaborate because one or both of the objects need somethning out of that relationship");
            Console.WriteLine("So they work in concert to fulfill larger responsabilities inside of the system");
            Console.WriteLine();
            Console.WriteLine("When we are designing collaborations, we have to consider objects as partners working together and not as isolated individuals");
            Console.WriteLine("It is helpful to look at common kinds of types of roles called \"stereotypes\" to better understand what an object is doing in a collaboration relationship");
            Console.WriteLine("In other words, if we look at all the possible things that object can do, we can boil it down to just basically half a dozen typical activities or responsabilities in any system");
            Console.WriteLine("We oversimplify those responsabilites in order to help us focus on the responsabilities at a higher level. So a higher level of abstraction");
            Console.WriteLine();
            Console.WriteLine("OBJECT ROLE STEREOTYPES");
            Console.WriteLine("Oversimplifying and characterizing to understand an object's role more easily");
            Console.WriteLine("PERSPECTIVE");
            Console.WriteLine("INFORMATION HOLDER     - Knows and provides information");
            Console.WriteLine("STRUCTURER             - Maintains relationship between objects and information about those relationships");
            Console.WriteLine("SERVICE PROVIDER       - Perform work and, in general , offers computing services ");
            Console.WriteLine("COORDINATOR            - Reacts to events by delegating tasks to others");
            Console.WriteLine("CONTROLLER             - Makes decisions and closely directs others actions");
            Console.WriteLine("INTERACER              - Transforms information and requests between distinct parts of our system");

            Console.WriteLine("This stereotypes can be used as roles or responsabilities inside of our system for a particular object");
            Console.WriteLine("It is important to keep in mind that  a single object could fit into one of more of these stereotypes");
            Console.WriteLine("Now if it tries to do too much, then maybe it is time to rethink that particular object");
            Console.WriteLine("On the other hand, if the object is simply and information holder and that's all that it is, it might be critized as being \"anemic\"");
            Console.WriteLine("In another words , it might be critized for not doing enought for the system ");
            Console.WriteLine();
            Console.WriteLine("We might describe objects in terms of how many stereotypes that they actually implement");
            Console.WriteLine();
            Console.WriteLine("We might say that an object is smart when it both encapsulates data and that data affect the desisions that particular object makes and how fulfills its responsability");
            Console.WriteLine("We might say that object is pesky object because it has to ask its collaborators for every little detail to perform its responsabilities");
            Console.WriteLine();
            Console.WriteLine("It is trial and error process whenever you are designing objects in their collaborations");
            Console.WriteLine();
            Console.WriteLine("A well designed object supports a clearly defined role");
            Console.WriteLine("Design is an iterative and inceremental process of envisioning objects and their responsabilities and inventing flexible collaborations");
            Console.WriteLine();
            Console.WriteLine("We have one goal in object design and collaboration design and that is to create well defined objects that support a clearly defined role");
            Console.WriteLine("and we iterate through the incremental process of envisioning objects and their responsabilities and inventing flexibile collaborations");

            PressEnterForMainMenu();
        }

        public static void ConditionsOfUseAndAfterEffectGuarantee()
        {

            Console.Clear();


            Console.WriteLine("Collaborations are based on contracts.");
            Console.WriteLine("A contract can be explicity defined in terms of a \"method signature\" or an \"interface\"");
            Console.WriteLine("But a contract can be explicity express in terms of its conditions of use and its after effect guarantiees");
            Console.WriteLine("So as the book says, this is fine print of the contract");
            Console.WriteLine("Sometimes this is expressed in terms of data types");
            Console.WriteLine("Since C# is a strongly typed language, it would be difficult to send data to a collaborator that is of the incorrct data type");
            Console.WriteLine("It is defined in its method sigantures the types of input that it will accept");
            Console.WriteLine("In other circumstances like in a dynamic situation , we may not know ahead of time and so it would have to be the fine print would have to be expressed throught runtime exception");
            Console.WriteLine();
            Console.WriteLine("There are implicit ways of enforcing the fine print of the contract and that one of the implicit ways ytou can to that is throught structured exception handling in C#");
            Console.WriteLine("So every component has to trust its collaborators to be able to do the work that it been assigned to do.");
            Console.WriteLine("We have to be able objects have to to able to trust one another");
            Console.WriteLine("So this verification is usually in the form of input validation");
            Console.WriteLine("We are cheking to ensure that the data type is correct data if dynamic types are involved");
            Console.WriteLine("We are checking to ensure that the data is not null as it comes in through our method signature");
            Console.WriteLine("We are checking to ensure that data falls within accepted range of boundaries and so on");
            Console.WriteLine();
            Console.WriteLine("Ideally there would be some declarative way to include this fine print up front");
            Console.WriteLine("Usually it is just sufficient to just use existing exception objects that are buil into NET framework or create custom exceptions that are based on system.exceptions");
            Console.WriteLine("We rely on C# try catch and finally yo safeguard collaborative messages to ensure that they are successful and that they dont violate the fine print of the constract");
            Console.WriteLine("Then finally i guess another way to make sure that objects abide by the fine print of the contract is through unit testing");
            Console.WriteLine("We can make sure that as we refactor our code over time we haven't regressed and introduced some violation of the fine print of the contract for a particular method in our object");
            Console.WriteLine();
            Console.WriteLine("I suppose you caould say each object should provide and after effect guarantee");
            Console.WriteLine("You give me valid input, i guarantee the output");
            Console.WriteLine("We explicity define the after effect guarantees contractually in our method return types");
            Console.WriteLine("We are back to we are acceptin certain input types and we are returnign values of a certain output type. THat only garanties the data type.");
            Console.WriteLine("That' s that may not be enough. Here again we have to make a decision and it usually comes down to how much should the object trust its collaborators ");
            Console.WriteLine("If i dont trust  them, then you probably shoud add a try catch around every single call that ever made outside of your object  at that point you can verify incoming data and you can verify ehat comes out of the object what is returned by the method call ");
            Console.WriteLine("But probably the best way to guarantee the after effect of your object is to actually build unit tests");
            Console.WriteLine("And the more unit test you write with sample input code and that produce the desired result, you and your team members will begin to trust the objects to do their job");
            Console.WriteLine("And again if we make a change you can re test the regression make sure the we havent fallen back and actually broken something");
            Console.WriteLine("Ideally , in order for there to be collavoration, there has to be trust. The trust that you are going to give me what i need, and thust that i am going to return back to you what you need");
            Console.WriteLine("The way that we establish trust is to verify our inputs and our outputs");
            Console.WriteLine("We can do that live at runtime or we can do it ahead of time using unit tests");

            PressEnterForMainMenu();
        }


        public static void DomainVSApplicationSpecificObjects()
        {
            Console.Clear();

            Console.WriteLine("The principle of separation of concerns.");
            Console.WriteLine("The notion of the separation of concerns is true at so many different levels");
            Console.WriteLine("Whether it be from a macro or a micro perspective");
            Console.WriteLine("At an architectual level, the way that we used it previously ,we saw how useful that idea was");
            Console.WriteLine("but now we are going to apply to a much granular level with regards to objects and responsabilities that we assign to them");
            Console.WriteLine();
            Console.WriteLine("SOLID pattern -");
            Console.WriteLine("each letter is an acronym for one principle of object-oriented programming from an object design perspective");
            Console.WriteLine("S - single responsability principle (SRP) - separation of concerns - A class should have only one reason to change, meaning it should perform exactly one job ");
            Console.WriteLine("O - Open/closed principle (OCP)  - Software entities (classes, modules,functions ) should be open for extension, but closed for modification");
            Console.WriteLine("L - Liskov substituiton principle (LSP) - Derived class must be completely substituatable for their base classes without breaking the application");
            Console.WriteLine("I - Interface segregation principle (ISP) - A class should not be forced to implement interfaces and methods that it does not use");
            Console.WriteLine("D - Dependency Inversion Principle (DIP) - High-level modules should depend on avstraction (like interfaces) not on concrete implementations");
            Console.WriteLine();
            Console.WriteLine("Than I just want to talk about the different roles that object can play in a system and talk about how we separate concerns out by the type of role ");
            Console.WriteLine("Now this is not object stereotyping. ");
            Console.WriteLine("I m looking at this now from a different facet and there are really two different roles that an object can play . There are \"domain specific objects\" and there are \"application specific object\"");
            Console.WriteLine("Domain specific object");
            Console.WriteLine("Domain specific objects are objects that are used to model real world into an abstraction that we use in our conceptual machinery to create a solution");
            Console.WriteLine("Application specific object");
            Console.WriteLine("Those are objects that are required in order to perform system related tasks. We will use them for persistence for display , whether it be on a computer display or web page");
            Console.WriteLine();
            Console.WriteLine("Domain specific objects are born from an analysis of our problem domain nad these represent again abstractions of the real world specific to our particular type of application");
            Console.WriteLine("Domain objects represent concepts that will probably be familiar to users and exprerts within given specific field of interest");
            Console.WriteLine("The domain is made up of information and services that the user need along withs structures that can relate the two both information and services");
            Console.WriteLine("There are also containters for domain logic or business logic code , logic that is expressed purely in domain terms");
            Console.WriteLine("You can see it those instances, we are speaking now purely in terms of terminology that could be understood by domain expert, a tax expert etc ");
            Console.WriteLine("So those are going to be domain objects. Thay are concerned about the problem domain, not about all the other junk that has to go on to make this into a computer system");
            Console.WriteLine();
            Console.WriteLine("That's where application specific objects come into play .Application specific objects are born purely from our own imagination and are kind of like bridges between the domain world and the software world");
            Console.WriteLine("We are going to write these application specific objects to kind of wrap around the computer world so that it can interact with our domain world");
            Console.WriteLine("We will create a set of objects that interface with the network with the screen,output some file format like HTML or XML , or JSON. It will act with interact with the database for persistence or some cashing etc");
            Console.WriteLine("That the job of an application specific object to kind of be that bridge between the business world and the physical world");
            Console.WriteLine("Entity framework is really a good example of marrying these two world together. Some of this is done automatically for you. It will generate code for you based on some tooling in Visaul studio that will make this whole process a little bit easier");
            Console.WriteLine();
            Console.WriteLine("We may have other objects that perform the role of coordination between the domain and the physical computer system Api. We usually cal those \"Services\"");
            Console.WriteLine("WE may have still other objects that perform more utilitarien functions in the system. This might be a good candidate for reuse ");
            Console.WriteLine("If we need to process a given file in a specific way in our system, there is a cnahce that other people in our organization might need that same processing feature");
            Console.WriteLine("They may need to save the data in a specific file format specific ti your company or maybe just, a file format that' new and nobody else has built a library around");
            Console.WriteLine("And others can then gain the benefit of it by you taking those application specific objects and kind of packaging them up in a certain way and then being able yo share those object in a package with orhers");
            Console.WriteLine("Great example of this is actually JSON.NET  by James Newton King of Newtonoft - even Microsoft new API rely on JSON.NET for handling JSON");
            Console.WriteLine("Ideally, you would collect those object togeher, separating them into neighborhoods of concerns , and then package them up for reuse");



            PressEnterForMainMenu();
        }


        public static void ComponentsAsNeighborhoodsOfOBjects()
        {
            Console.Clear();


            Console.WriteLine("Sometimes it is a good idea to package neighborhhods of collaborating objects together inside if component for redistribution or for sharing");
            Console.WriteLine("Component is simply just a reusable package of objects that we defined");
            Console.WriteLine("In a different programming languages and operating system and frameworks this will take different forms");
            Console.WriteLine();
            Console.WriteLine("In the .NET wolrd it usually take the form of \"Class library\"");
            Console.WriteLine("You  have a class library project. When you compile a class library project, it is going to create a net assembly");
            Console.WriteLine("Typically, the net assembly will have a DLL file extension. Inside that assembly, we have a number of classes");
            Console.WriteLine("We defined a neighborhood of classes that all kind of contribute to do something meaningful");
            Console.WriteLine("Like Newtonoft's JSON.NET library - this is a great example of functionality of classes that were compiled together into a component for redistribution");
            Console.WriteLine();
            Console.WriteLine("We also get in .NET world a NuGet - for a distribution from a centralized repository version and dependency management");
            Console.WriteLine("Reuse is one of the benefits of object-oriented programming ");
            Console.WriteLine("This used to be considered the holy grail of object-oriented programming . We write it once, we will never have to write it again");
            Console.WriteLine("It took time and a lot of failuires. That is why we have principles that we have today because a lot of lessons were learned in that time");
            Console.WriteLine("But it would no longer weas the holy grail. It kind of became something that everybody said was impossible to achieve in reality");
            Console.WriteLine("The same is true with neighborhoods of objects. Object should stay in their neighborhood based on their zoning or their purpose.");
            Console.WriteLine("Now in practical terms i suppose it means first of all that ideally components shoud contain either domain specific objects od application specific objects");
            Console.WriteLine("But not both, when you are mixing that boundary then you are definitily oversteping two zones");
            Console.WriteLine();
            Console.WriteLine("Second implication is that i think ideally components shoudl be narrowly foacused on a very specific task");
            Console.WriteLine("Third thing to consider is that ideally component should define interfaces that allow its dependencies to be sent or delivered or injected into it");
            Console.WriteLine();
            Console.WriteLine("Dependency injection and inversion of control");
            Console.WriteLine();
            Console.WriteLine("The fourth observation along these lines is that ideally components should be composed if neighborhoods of objects that are engaged in similar work or have similar goals");
            Console.WriteLine();
            Console.WriteLine("These sorts of things, these neightborhood associations, these zoning laws, will begin to reveal themselves when we begin to look at the types of messages that are going to be excanged betwwen objects");
            Console.WriteLine("Ther will be some natural organic segregation of components based on their common goals");
            Console.WriteLine("Idiom - birds of a feather flock together - should be observed and shoud be honored whnoever we are thinking about packaging classes, objects into own neightborhoods for reuse ");
            Console.WriteLine("Not only does this keep collaborating objects in their own neighborhoods and help reusability, but it is also a mechanism that can be used for human collaboration");
            Console.WriteLine();
            Console.WriteLine("The Ability to divide up a large piece of work and conquer it with several different members or teams, this is one of the things that makes object-oriented programming so appeling");
            Console.WriteLine("It is all possible whenver we are planning ahrad of time and designing our objects and putting them in their natural neighboroods and then repacking those neightborhoods into components for reusability");



            PressEnterForMainMenu();
        }

        public static void ArchitectualLayersOfResposnabilityUsingObjects()
        {
            Console.Clear();



            Console.WriteLine("You can also split up objects into neighborhoods for the purpose of divvying up worload between team members or entire team");
            Console.WriteLine("There was some natural segregation that will occur based on segragation of the objects based on the type of messages that will be sent and the collaboration that will be shared between objects");
            Console.WriteLine("There will be collaboration preferences that objects demonstrate based on the commonality of the work that certain objects will be tasked with handling");
            Console.WriteLine("Architectual perspective that a layer is composed of several collaborating components that are tasked with the same sort of work but more from a system perspective");
            Console.WriteLine("The classic breakdown is persistence, domain layer, presentation, web services, things of that nature");
            Console.WriteLine();
            Console.WriteLine("When it comes to domain objects you may have some natural divisions between the tasks of the domain objects related to their business function");
            Console.WriteLine("The fact of the matter is that these components all fit into a layer of our software called the domain layer");
            Console.WriteLine("Application specific objects live in components that can fit into the persistence layer, the presentation layer, a web services layer");
            Console.WriteLine();
            Console.WriteLine("So when diving up the responsabilities of the system and assigning them to individual objects we have to keep in mind that there are really two perspective");
            Console.WriteLine("First of all there is the domain responsability");
            Console.WriteLine("Second there is the application responsability");
            Console.WriteLine("And inside of the application specific responsability, there might be objects that know how to handle specific object, or domain object or component from a system perspective");
            Console.WriteLine();
            Console.WriteLine("ARCHITECTUAL LAYERS OF RESPONSABILITY");
            Console.WriteLine("Matrix of Application-Specific and Domain-Specific Objects by Architectual Layer ");
            Console.WriteLine("              | Accounting              |    Marketing             |      Retail              |   Tax            <- Domain Responsability ");
            Console.WriteLine("Presentation  | Application Objects     |   Application Objects    |    Application Objects   |   Application Objects ");
            Console.WriteLine("Domain        | Domain Objects          |   Domain Objects         |    Domain Objects        |   Domain Objects   ");
            Console.WriteLine("Persistence   | Application Objects     |   Application Objects    |    Application Objects   |   Application Objects ");

            Console.WriteLine();
            Console.WriteLine("There is a matrix of sorts that begins to evolve on one axis you have the domain responsability and on the other axis you have the application responsability");
            Console.WriteLine("Each of resulting squares that you get  , they represent a component of objects that are build to handle that particular responsability");
            Console.WriteLine("Each of resulting rows in that diagram are a layer of system responsability whether presentation domain etc  ");
            Console.WriteLine("Each of resulting columns represent a slice or a spike of application responsability from a domain perspective");
            Console.WriteLine("It creates a bunch of squares and at the border of each square , that repsersents a logical place where interfaces would exist");
            Console.WriteLine();
            Console.WriteLine("Interfaces between different components in the various areas of domain layer and then obviously interfaces between layers as well between the persistence and the domain and trhe presentation");
            Console.WriteLine();
            Console.WriteLine("We are really talking about building some slice of the application, a fully working set of features that span all the architectual layers");
            Console.WriteLine("Building those classes and components that will interact to perform some subset og all the features that we exprect to see in final application and is so doiung we are provdinig a concrete example of an application throught all the architectual layers");
            Console.WriteLine("It will demonstate the interaction of the component neightborhoods across all the parts of the system to create a mini application that can demonstate to the end user or the project sponsor that hey the application is working");
            Console.WriteLine("But it will also be beneficial in so much that it will demonstrate to other developers on the team how the application will be architected in a very tanglible way");
            Console.WriteLine("We can use that to see all of the layers, all of the components come together to build an entire application");
            Console.WriteLine();
            Console.WriteLine("The objects will collaborate mostly within their own layer and typically even within their own neighborhoods , by functionality, by square");
            Console.WriteLine("In any application when objects reside in different layers and they need to collaborate then client objects are usually above server objects ");
            Console.WriteLine("THe message will start at the top and they will flow mostly downward");
            Console.WriteLine("Information however will flow mostly or result will flow mostly upwards");
            Console.WriteLine("And then when messages flow up in those rare cases where that happens, client objects are in lower layers and they are coupled to their server objects");
            Console.WriteLine("This usually menas that there is some eventing mechanism in play there");
            Console.WriteLine();
            Console.WriteLine("Only the topmost layer and the bottom most layer are really are what you woulkd say are exposed to the outside world");
            Console.WriteLine("The top the presentation layer, at the bottom the persistence layer");
            Console.WriteLine("Those are both platform specific");
            Console.WriteLine("On the top you have to display components, whether that be with HTML,WPF or Xamarian etc ");
            Console.WriteLine("And then on very bottom you have device and external system interfaces, whether it to be the network, to a database server, to a cashicn mechanism");
            Console.WriteLine();
            Console.WriteLine("How the notion of collaboration and responsabilities we begin to put things into containers and categories and things start to get sorted out for us as we begin to understand the design of the system");


            PressEnterForMainMenu();
        }

        public static void DesigningObjectAndInteractions()
        {

            Console.Clear();


            Console.WriteLine("How do we design individual objects in our conceptual machinery? How do we know whne our objects are well defined at all");
            Console.WriteLine("How do we know that the object is not overreaching its boudaries of its domain or apllication specific responsibilities ?");
            Console.WriteLine();
            Console.WriteLine("There is not single answer to this question");
            Console.WriteLine("A well defined object supports a clearly defined role. And that design is an iterative and inceremental process of envisioning objects and their responsibilities and inventing flexible collaborations");
            Console.WriteLine("Fortunaly, we do have some patterns and principles that help us discover elegant ways of handling common problems");
            Console.WriteLine("I mean common interactions or collaborations between objects and they have been left to us by practitioners over the course of the last several decades");
            Console.WriteLine("We get to decide as developers, we get to apply that advice. WE get to apply those patterns and those principles situationally to our own problem domain");
            Console.WriteLine("This is not a one-time process,but it is an ongoing process ");
            Console.WriteLine("We should never take the attitude that our decisions are final");
            Console.WriteLine("Everything should always be opet for re-evaluation");
            Console.WriteLine("We have to be willing to and able to refactor our code when a requirent demands that we consider the new practice or pattern");
            Console.WriteLine();
            Console.WriteLine("What are these principles and patterns that we should at least consult before we go off and make a decision specific based on our problem domain");
            Console.WriteLine();
            Console.WriteLine("The sources for the priciples is the kind of the mother of them all is from the gang of four  ");
            Console.WriteLine("It a book entitled \"Design Patterns\" - four authors that have been instrumental in helping to document design patterns ");
            Console.WriteLine("Now the challenge with this book is that it is very difficult to read ");
            Console.WriteLine("And it is typically written out in eighter Java or C++, some of the terminology they used are over my head");
            Console.WriteLine();
            Console.WriteLine("The next book  \"Appying uml and patterns\" by Craig Lman  ");
            Console.WriteLine("3 rd book to read is  from Uncle Bob Martin - \" Agile, Principles,Patterns and Practices in C#\" ");
            Console.WriteLine();
            Console.WriteLine("4 th book that Bob recommend is \"Head First Design patterns\" by O 'Relly");
            Console.WriteLine("Book \"Design pattern\" is more technical and difficult to read, but the rest of them ,especially Uncle Bob is for C# written is more suitable for .NET");
            Console.WriteLine();
            Console.WriteLine("You can really spend a lifetime mastering all of this. And  any road that you decide to kind of go off on a tangent , it will pretty much lead out info infinity");
            Console.WriteLine();
            Console.WriteLine("But it all comes back to some basic tenants . And if you can get those right, ytou can probably build your application in such a way tyhat it can withstand the inevitable impact of change on the software system");
            Console.WriteLine("If we can just get that under our belt, then we will be doing fine . You can make a career out of all of this. ");
            Console.WriteLine("Many people have , it is unfortunately both appeling and dauting at the same time because there is just to much to learn and so little time to learn it");


            PressEnterForMainMenu();
        }

        private static void FourPillarsOfOOP()
        {
            Console.Clear();

            Console.WriteLine(" ==== FOUR PILLARS OF OOP ==== ");
            Console.WriteLine();
            Console.WriteLine("1. Abstaction");
            Console.WriteLine("2. Encapsulation");
            Console.WriteLine("3. Inheritance - implementation ||  interface ");
            Console.WriteLine("3A Implementation inheritance");
            Console.WriteLine("3B Interface inheritance");
            Console.WriteLine("4. Polymorphism");
            Console.WriteLine();
            Console.WriteLine("9. Povratak na glavni meni");
            Console.WriteLine("99. Napusti program");
            Console.WriteLine();
            Console.WriteLine("Odaberite opciju od 1 do 4 ili 99 za napustanje programa");
           


        }

        public static void ChooseToDisplayFourPillarsMenu()
        {
            bool showMenu = true;

            while (showMenu )
            {
                FourPillarsOfOOP();

                string userInput = Console.ReadLine();

                string filteredUserInput = userInput.Trim().ToLower();

                showMenu = SwitchFourPillarsOfOOP(filteredUserInput);
            }
        }

        private static bool SwitchFourPillarsOfOOP(string input)
        {
            switch(input)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Abstaction");
                    Console.ReadLine();
                    return true;

                case "2":
                    Encapsulation();                   
                    return true;

                case "3":
                    Console.Clear();
                    Console.WriteLine("Odaberite 3A ili 3B");
                    Console.ReadLine();
                    return true;

                case "3a":
                    ImplementationInheritance();
                    return true;

                case "3b":
                    InterfaceInheritance();
                    return true;

                case "4":
                    Polymorphism();
                    return true;

                case "99":
                    ExitProgram();
                    return false;

                case "9":
                    ChooseToDisplayMainMenu();
                    return false;

                default:
                    Console.WriteLine("Greska");
                    Console.ReadLine();
                    return true;


            }
        }

        public static void Encapsulation()
        {
            Console.Clear();


            Console.WriteLine("Object oriented programming is all about boundaries and relationships and communication across those bondaries");
            Console.WriteLine("Through the relationships that objects have with one another");
            Console.WriteLine();
            Console.WriteLine("The major tenets of object-oriented programming");
            Console.WriteLine("The word tenet is not a word that we use frequently. It is defined as a principle or a belief, especially one of the main pricniples of a given religion or philosophy");
            Console.WriteLine("We use the term tenant to express some of the highest guiding principles and concepts in object-oriented programming from which all the other things flow that we will learn about");
            Console.WriteLine();
            Console.WriteLine("There are four tenets of object-oriented programming.");
            Console.WriteLine("1. \"Encapsulation\"");
            Console.WriteLine("2. \"Inheritance \" ");
            Console.WriteLine("3. \"Polymorphism \" ");
            Console.WriteLine("4. \"Abstraction \"");
            Console.WriteLine();
            Console.WriteLine("Encapsulation ");
            Console.WriteLine("Encapsulation is a mechanism that is used to hide the implemetation details of a class");
            Console.WriteLine("This will take several different forms");
            Console.WriteLine("Class is made up of information, typically fields of information , and then it is made of functions which we call  object oriented methods ");
            Console.WriteLine("Those methods operate on the information the fields, or use that information in some way to perform a task that we have delegated to it");
            Console.WriteLine("It has a responsability.We have delegated that responsability ");
            Console.WriteLine("We encapsulate the information to be hidden from other classes first of all, and we restict access to that information");
            Console.WriteLine("We restict access to fields, throught use of properties");
            Console.WriteLine();
            Console.WriteLine("Property consist of two parts.It has getter and setter.They are really two methods, although they dont look like methonds in full definition of a property  ");
            Console.WriteLine("We can use these property getters and setter methods as gatekeepers. They protect the data the underlying fields of information to ensure that data is set to a proper value within a certain range of accepted values");
            Console.WriteLine("Perhaps from a getting standpoint it is only available to people with certain permissions in the system ");
            Console.WriteLine("Like shown down in class Car");
            Console.WriteLine();
            Console.WriteLine("We might also encapsulate all of the functionality of a method behind a couple of public methods");
            Console.WriteLine("So we might break up a task that we delegate to a method into several helper methods ");
            Console.WriteLine("We might do it for a number of different reasons, not the least of which is for readability or for just to keep things scoped in a more manageable sort of way");
            Console.WriteLine("We can choose to hide a the private implementation details using the word private and expose one method that will make calls into those private methods, and expose that use the keyword public");
            Console.WriteLine();
            Console.WriteLine("The concept of encapsulation");
            Console.WriteLine("Analogy with a nosy friend, somebody who wants to know a little bit too much about your private life and maybe even wants to insert themselves into your private world");
            Console.WriteLine("We want our objects to have healthy relationships whenver they collaborate with each other");
            Console.WriteLine("An object that share too much information about its own implementation invites others to use the object in unintended ways ");
            Console.WriteLine("Let just say that our private method its tied to uor objects private implementation of its responsabilities");
            Console.WriteLine("If  i were able to call into one of the private methods here, I could never replace car or it would be difficult for me to replace this class with another class because this code knows way too much bout how this class does its job");
            Console.WriteLine("If you try to replace this object with a new version , the entire application becomes broken. Why? Because the object that this interacts with knows way too much about the object that is is interacting with");
            Console.WriteLine("It is abusing the proper contract of a work agreement");
            Console.WriteLine("So your object should share as little as possible in order to do its work");
            Console.WriteLine("This makes for a cleaner collaborative relationship between your object and other objects");
            Console.WriteLine("It means your object can more be more easily replaced with a different object that has the same basic interfaces in terms of the method signatures and such but with a different implementation");
            Console.WriteLine();
            Console.WriteLine("Encapsulation is the first tenant of object-oriented programming. ");
            Console.WriteLine("It contributes to helping us build more maintainable code because it enforces boundaries in a collaborative relationship");
               

            PressEnterForMainMenu();
        }


        public static void ImplementationInheritance()
        {
            Console.Clear();

            Console.WriteLine("The second tenant of object-oriented programming is inheritence ");
            Console.WriteLine("Inheritence is where an object is based on another object borrowing its implementation for some of its responsabilities or creating new specilaed implementations for other responsabilities");
            Console.WriteLine("And perhaps even adding new implementation for responsabilities that are unique to the inheriting object");
            Console.WriteLine();
            Console.WriteLine("Inheritance can also be in form of a contract or an interface");
            Console.WriteLine("So an object can implement one or more interfaces which define properties but more likely define methods that must be implemented to satisfy the conditions of the contract");
            Console.WriteLine();
            Console.WriteLine("When we talk about inheritance there is actually two different kinds of inheritance ");
            Console.WriteLine("* Implementation inheritance");
            Console.WriteLine("* Interface inheritance");
            Console.WriteLine();
            Console.WriteLine("Implementation inheritance.  There is at least two classes in inheritance .There is a parent class and it is child class. ");
            Console.WriteLine("The child deres its functionality, its properties and methods from the parent or that relationship can be described ad a superclass and subclass");
            Console.WriteLine("Superclass which has a number of methods and properties , and you have subclass which inherits all of those ");
            Console.WriteLine("Subclass can decide to override some , add additional features for specialization, whatever the case might be");
            Console.WriteLine("There is also a base class and the derived class it all sininims for the same relationship ");

                    


            Console.WriteLine();
            Console.WriteLine("1* At first glance, you might see some benefit in terms of code reuse ");
            Console.WriteLine("2* But override and extend the parts that you nedd to create a specialized version of that object specific to the responsabilities that we as the developers will delefate to that child object in the system");
            Console.WriteLine("3* The flexibility that it gives to collaborations. ");
            Console.WriteLine("We can create similar but different implementations of the machinery thats needed to create and object that has some variances");
            Console.WriteLine("Implementation inheritance makes out collaborations much more flexible because we are able to generalize our collaborations between objects allowing for specializes child version of those collaborating object to be used in line of the parent object");
            Console.WriteLine("Larger contribution to the object-oriented programming world is for the generalization and specialization of collaborating objects and this is really half , second half is polymorphism");
            Console.WriteLine("We will see why is it so powerfull when you combine implementation with inheritance with polymorphism");



            PressEnterForMainMenu();
        }


        public static void InterfaceInheritance()
        {
            Console.Clear();

            Console.WriteLine("Interface inheritance is similar to implementation inheritance in this regard when you have multiple objects that share the same basic shape");
            Console.WriteLine("In other words, when they support the same method signatures or properties ");
            Console.WriteLine("Interface inheritance take this whole idea one step further");
            Console.WriteLine();
            Console.WriteLine("Interfaces only define the public members of a class that must be implemented by a class in order to satisfy a contract between two or more object");
            Console.WriteLine("So it is a contract of communication. There is no implementation to fall back on when you create an interface");
            Console.WriteLine("");
            Console.WriteLine("But in superclass - subclass there is  implementation inheritance that  you can always rely on the parents implementation ");
            Console.WriteLine();
            Console.WriteLine("Interface inheritance has a whole different purpose and while it is similar its purpose is different");
            Console.WriteLine("You use intefraces to define an abstraction that breaks a depencency ");
            Console.WriteLine("Interface represents a contract for services that I need rendered or speaking as an object, I need something done.");
            Console.WriteLine("So I will put a contract out there and saay if anybody can work with me, here is the contract that you will have to fill on your side ");
            Console.WriteLine("You have to satisfy on your side. The other object can accept the terms of the contract, and implement the terms of the contract ");
            Console.WriteLine();

                    

            Console.WriteLine();
            Console.WriteLine("What happens when I want to add another type of object? ");
            Console.WriteLine("I would have to come in adn create a new helper method for each one of these");
            Console.WriteLine("This seems like not the right place to do that because the code passage could get longer and longer over time");
            Console.WriteLine();
            Console.WriteLine("First of all I don't even have the information necessary yo go off and know what needs to be printed and how it needs to be printed");
            Console.WriteLine("I rather have the information holder who the object that knows the information be the one responsible for formatting and then printing out to screen the value inside of its own instance");
            Console.WriteLine("I need to create like one method  \"static void DisplayYourself\" then you need to implement IDisplayable  ");
            Console.WriteLine("We create interface with \" public interface IDisplayable \" ");
            Console.WriteLine("In the body of interface we will just put method without implmentation  void Display(); ");
            Console.WriteLine("Now in the class we must implement interface with IdIsplayable , and with it it must be implemented all the methods from interface");
            Console.WriteLine("But after that ww will call only one Method ()  \" DispayYourself(car)   DisplayYourself(book)  - which will shown these methods");
            Console.WriteLine("Now the \" DisplayBook and DisplayCar \" are no longer needed , we are using their method implemetation on Car and Book class with method \" Display\" ");
            Console.WriteLine("The result wont be any different , but the way we got there is dramatically different");
            Console.WriteLine();
            Console.WriteLine("And now at this point on the program class doesn;t need too much information about how to display objects that it holds a reference to");
            Console.WriteLine("It is going to depend on the fact that they implement this contract and that they know hoe to display themselves as a result");
            Console.WriteLine();
            Console.WriteLine("Any object that implements a contract can be used. Since any object that implements a contract can be used that means two things");
            Console.WriteLine("First we removed a tight coupling that our object may have to other objects");
            Console.WriteLine("We really see that more here in Displayyourself . There is not a tight coupling .Like it was in methind that belonged to Car or Book. ");
            Console.WriteLine("It is just very generic and we can pass anything into it ");
            Console.WriteLine("Since our object is not coupled and it only depends on a specific coupled in such a way that it depends on a specific object type ,");
            Console.WriteLine("but now any object that implements our Idisplayable contract we can isolate our object more easily ");
            Console.WriteLine("Now if we wantend  to unit test main for example, we could isolate it and then perform utit test  ");
            Console.WriteLine();
            Console.WriteLine("Similar to encapsulation, it keeps our collaboration simple and flexible because we have established clear boundaries ");
            Console.WriteLine("We dont want one object so tightly coupled to another object ");
            Console.WriteLine("Interface inheritance helps us to separate our concerns in clear lines");



            PressEnterForMainMenu();
        }

        public static void Polymorphism()
        {
            Console.Clear();

            Console.WriteLine("The third tenant of object - oriented programming is polymorphism");
            Console.WriteLine("It comes from Greek, it literally means  - many forms or many shapes ");
            Console.WriteLine("Polymorphism allows you to call the same method on different objects as long as it truly the same method");
            Console.WriteLine("The same method signature, same input parameters, same return values or types, same name , so on");
            Console.WriteLine();
            Console.WriteLine("Id three different object all have a different version of the same method, then our caller really doesn not care which object that it is working with");
            Console.WriteLine("All it needs to know is that they all are supporting the same method. It just needs to be able to get a reference to one of those objects and then trust that the calling the method will perform the correct ");
            Console.WriteLine("responsability in the system relative to the purpose of that particular object");
            Console.WriteLine();
            Console.WriteLine("We get printed information about the car and information about the suv ");
            Console.WriteLine("With car with the info from make, model and year");
            Console.WriteLine("For suv we get , make, model, year and driving mechanism   - like it is suposed to get");
            Console.WriteLine();
            Console.WriteLine("In order to withness polymorphic behaviour , we are goig to take a look at this print method");
            Console.WriteLine("Print helper method will take anything of type autombile and present it");
            Console.WriteLine("That will include automobile and suv class ");
            Console.WriteLine("For automobile, we will get the same display we had previous, but for suv we will get the display from car which does not contain the drive method");
            Console.WriteLine("We are getting cars version for display method");
            Console.WriteLine();
            Console.WriteLine("In order to enable polymorphism in our code, we neeed to make two modifications to our code");
            Console.WriteLine("But if we in display method in car put \"virtual\"  then in display method in suv instead \"new\" we put \"override\" ");
            Console.WriteLine("This method can be completely overridden, notjust hidden but it can be even exteneded by derived class");
            Console.WriteLine("We are adding \"virtual\" keyword ");
            Console.WriteLine("Now i derived class we are replacing word \" new \" with word \"override\"");
            Console.WriteLine();
            Console.WriteLine("Then we will get the same result on the starting point ");
            Console.WriteLine("We see the polymorphic behaviour and it behaves correctly");
            Console.WriteLine();
            Console.WriteLine("It is the ability for you to use or to call a given method across multiple different types and for it to actually make a call in and use that particual version of that method");
            Console.WriteLine();
            Console.WriteLine("Polymorphism is our manifestation of our desire to build more flexible collaborations between objects");
            Console.WriteLine("Inflexible collaborations are limiting");
            Console.WriteLine("We are really not relying on a concrete direct reference to a specific object");
            Console.WriteLine("Here in our print method, we are just saying anything that comes down line from automobile. It can be automobile, suv, or engine");
            Console.WriteLine("We are not relying on specific object per se in order to call that method on than objec");
            Console.WriteLine("As long as the object that we pass in her has a method defined with that specific name then it has that specific input and it returns that particular return type");
            Console.WriteLine();
            Console.WriteLine("With polymorphysm - We decoupled the collaboration");

            PressEnterForMainMenu();

        }


        public static void UnderstandingRelationshipCouplingAndDependancy()
        {
            Console.Clear();

            Console.WriteLine("People who are codependent");
            Console.WriteLine("Wikipedia says excessive reliance on othe people for approval and a sense of identity leads to all sorts of issues for humans");
            Console.WriteLine("They become enablers for each other with regards  to substance abuse like alcoholism, drugs, gambling, addictions");
            Console.WriteLine("Less over like immaturity or irresponsibility or even underachievement");
            Console.WriteLine();
            Console.WriteLine("But objects can form unhealty relationships with each other as well");
            Console.WriteLine("Some dependency is completely necessary ");
            Console.WriteLine("No object is an island unto itself");
            Console.WriteLine("Object should and must collaborate together");
            Console.WriteLine("But when a relationship becomes unhealthy is when we begin to notice certain telltale signs of unbreakable codependence, which in programming circle is known as coupling");
            Console.WriteLine("So we should strive to design objects that have low coupling");
            Console.WriteLine();
            Console.WriteLine("The most obvious sign of an unhlethy relationship is when we notice that one concrete object is directly creating and instance of another concrete object in order to collaborate with each other");
            Console.WriteLine("Now that could be a helathy relationship if two objects are living in the same neighborhood like we discussed several lessons ago");
            Console.WriteLine("Remember with boundaries. So from a domain responsability and application responsability perspective, if you have two objects in the same domain responsability and in the same architectual layer , then you are probabbly ok");
            Console.WriteLine();
            Console.WriteLine("But if two objects are engaged in interboudary relationships and one creating a concrete instance of the other one using the new keyword, then you might have a problem , and you probably want to break that dependency");
            Console.WriteLine();
            Console.WriteLine("First is when a domain specific object has a direct dependency on a application specific object");
            Console.WriteLine("Then we violated the separation of concerns principle");
            Console.WriteLine("In this particular case violating ther saparation of concerns principle mean is problematic because our domain layer is now permanently bolted onto a implementation of our persistence layer");
            Console.WriteLine("Because we used the new keyword to create directly create a concrete object from one layer in another layer ");
            Console.WriteLine("This will limit us in several different ways ");
            Console.WriteLine("It is going to limit us our ability to swap out implementations of our persistent objects, which in turn limits our ability to unit test our domain object and grow confident in its ability to implement the fine print");
            Console.WriteLine("We will solve it through inversion of control and dependency injection");
            Console.WriteLine();
            Console.WriteLine("We have a car, which I would classify as a domain object.");
            Console.WriteLine("But we see it does have a method where it is creating a new incance of this other class called CarPersitence to file ");
            Console.WriteLine("And this is what I would call an application specific object");
            Console.WriteLine("This object would probably live in another project in our solution");
            Console.WriteLine("It would be typically be a class library that we would assign  the responsability of being a persistence layer");
            Console.WriteLine();
            Console.WriteLine("From an architectual standpoint you typically wouldn't have these in the same file");
            Console.WriteLine("But you have two fundamentally different concerns. One is domain, one is application specific");
            Console.WriteLine("In our example we created a new instance of this, and a created an interbouindary relationship by gluing together our domain class with our application specific class");
            Console.WriteLine();
            Console.WriteLine("The problem with this , is that if we ever want to replace the way that this class is persisted. This will kind of hard to do because we have glued our domain class directly yo our persistence");
            Console.WriteLine("They are across boundaries , and yet now they have a weird codepenndancy where one has to be there for the other one to work");
            Console.WriteLine("That the case where we have a domain specific object that tightly coupled to an application specific object that is in another architectual layer");
            Console.WriteLine();
            Console.WriteLine("Two domain specific objects that just happen to be in two different domain responsabilities");
            Console.WriteLine("Domain specific object in accounting and a domain specific object in tax and the accounting object creates an instance of tax in that case");
            Console.WriteLine("You can do that, but it is still undesirable . That kind of coupling will shorten the lifespan of the application ");
            Console.WriteLine("Futher more we are not able to isolate that domain object for unit test");
            Console.WriteLine("Sometimes it is difficult to set up integrated tests between inner boundary layers");
            Console.WriteLine("That is why is so important to make sure that there is not these strong coupled objects ");
            Console.WriteLine("One reason is for swithin the implementation, and the second reason is for unit testing");
            Console.WriteLine();
            Console.WriteLine("We can see that hight coupling across domain or application specific object boundaries is problematic because it makes our application brittle and untrustworthly and furthermore we are not able to swap out implementations");
            Console.WriteLine("So coupling across domain responsabilities can be problematic");
            Console.WriteLine();
            Console.WriteLine("Solid - S  , single responsibility principle it states the our object should have only one reason to change");



            PressEnterForMainMenu();
        }

        public static void InversionOfControlInterface()
        {
            Console.Clear();

            Console.WriteLine("How to break up an unhealthy relationship between two of our objects ");
            Console.WriteLine("We invert the control of dependencies instead of as we  have here. Instead The domain object depending on our persistence object ,we are going to flip the dependency so that the persisten object depends on the domain object instead");
            Console.WriteLine("When the domain object knows that it needs services from the persistence layer architectually, it must rely on an outsider to coordinate that interaction and inject that dependency into it");
            Console.WriteLine("Whenever we want to unit test that domain object it is coupled too strongly to the persistence layer object");
            Console.WriteLine("It can't be isolated and we can't examine it to make sure that it by itself will fullfill tha as i have been using the terms the details  of the contract");
            Console.WriteLine("So we have to rewrite the domain object and help it rehabiliate it so that it will say I know I need some help ");
            Console.WriteLine("I am not going to be tied down to just one object because that not healthy for me. Instead I am going to publish contract and an interface ");
            Console.WriteLine();
            Console.WriteLine("First thing is we are going to define an interface. And this is from the perspective of the consumer of the service");
            Console.WriteLine("Car is going to consume the services of a persistence object. So it needs to be the one defining what the contract terms are ");
            Console.WriteLine("Right there between car and car persistence , we will put interface ");
            Console.WriteLine("The next step is then for any class that wants to be persistence for the car it need to implement this interface");
            Console.WriteLine("We are allowing to CarPersistence class to inherit interface");
            Console.WriteLine("Now in the car class we are going to remove a direct dependency ");
            Console.WriteLine("In class car we are going to construct dependency injection ");
            Console.WriteLine("In class car we are defining \"  private IICarPersistence _carPersistence; \" we created a private field ");
            Console.WriteLine("This will hold on to a reference of what object we are going to use to do the persistence");
            Console.WriteLine("Here in constructor , i am going to demand that you give me that object ");
            Console.WriteLine("We are going to pass it in as an argument to the constructor and then we will hold to an reference to it ");
            Console.WriteLine("In Car constructor we are passing CarPersistece  and inside we are asising carPersistence to _carPersistence");
            Console.WriteLine("Now we can change to var file = _carPerisitance  or even beter to only _carPersisitence.SaveCar()");
            Console.WriteLine("We are changint to readonly  .. now  \" private readonly IcarPersistence _carPersisnce field \"");
            Console.WriteLine("So now nothing else beside a constructor can modift our private instance of our dependency");
            Console.WriteLine();
            Console.WriteLine("SUMMARY ");
            Console.WriteLine("W broke the dependency, the direct dependency between two different layers of our architecture");
            Console.WriteLine("The car should never  have had direct codependant relationship with our car persistance to file class");
            Console.WriteLine("So to break the dependecy we introduced an inteface and we has car persistence to file implement tha interafce ");
            Console.WriteLine("THen we in our constructor we passed we asked for instance or our dependencies ");
            Console.WriteLine("We inverted the control instead of car controlling car persistence to file , it is now receiving its dependency ");
            Console.WriteLine("So we have inverted the flow of control in our application so that we can still call our save car method , but the mechanism is completely different now");

            Console.WriteLine();
            Console.WriteLine("There are more ways to dependency injection ");
            Console.WriteLine("First is constructor dependency injection");
            Console.WriteLine("Property dependency injection");
            Console.WriteLine("IOC container , inversion of control containter ");




            PressEnterForMainMenu();

        }

        public static void Aggregation()
        {

            Console.Clear();


            Console.WriteLine("Objects sometimes merely collaborate");
            Console.WriteLine("One object need help, it requests help from another object. After they collaborate, the task at hand, they move on with their lives");
            Console.WriteLine("Sometimes , objects share a tighter bond.Like we had in previous lessions ");
            Console.WriteLine();
            Console.WriteLine("There are two special types of relationships that we are going to look at next ");
            Console.WriteLine("Association - that is where you have just a normal collaboration");
            Console.WriteLine("There is relationship between two objects, but each of them ultimately have their own life cycle");
            Console.WriteLine("They dont own each other . There is no other futher relationship between, just one time association");
            Console.WriteLine();
            Console.WriteLine("Aggregation - this is sometimes known as a \"HAS A \" style relationship between objects ");
            Console.WriteLine("It denotes ownership or whole part or a this object is a part of this larger object");
            Console.WriteLine("You have a teacher ,and you have a departments at a give university , and some teacher can exist in muliple departments and a single department can have multiple teacher involved");
            Console.WriteLine("In a sence there is a sense in which departments own teachers. So there is an aggregation ");
            Console.WriteLine("One department can own or have posseed group of multiple teachers , and one teacher could conceivably have multiple departments that belongs to");
            Console.WriteLine("If a teacher were to be eliminated it would not eliminatie the department that she belonged to");
            Console.WriteLine("And vice versa, if you were to eliminate the department, the teacher could find another job at another department in the university");
            Console.WriteLine("But the teacher would still exist");
            Console.WriteLine();
            Console.WriteLine("We are really talking about two properties of the relationship");
            Console.WriteLine("One is life cycle, when do they live and when do they die");
            Console.WriteLine("The other one is ownerships");
            Console.WriteLine("In aggregation there is and ownership between one object and another object, but there is not a direct correlation of life cycle");
            Console.WriteLine("They live and die independent of eachother");


            PressEnterForMainMenu();
        }

        public static void Composition()
        {
            Console.Clear();


            Console.WriteLine("Final relatioship related topics for this course");
            Console.WriteLine();
            Console.WriteLine("1.  Association , a normal healthy relationship between two objects");
            Console.WriteLine("2.  Aggregation, which is a more permanent relationship where one object keeps references to other instances of objects");
            Console.WriteLine("However if that object were to go away, the objects that it references dont necessarily go away");
            Console.WriteLine("There are two properties of the relationship. There is life cycle , do these live on their own and die on their own");
            Console.WriteLine("Second there is ownership where at some point in time one object will essentialy own references to other ones");
            Console.WriteLine();
            Console.WriteLine("3.  Composition , which is a stronger version of aggregation");
            Console.WriteLine("In composition, the child simply cannot exist without its parent");
            Console.WriteLine("House and rooms . If you destroy the house, the rooms will be also destroyed");
            Console.WriteLine("House and room class, room class is designed inside the boundaries of a house class");
            Console.WriteLine("We have defined a class inside a class, that is one way of denoting ownership of one object to another");
            Console.WriteLine("Composition is both ownership and it denotes lifetime");
            Console.WriteLine("When we destroy the house, the kitchen should be gone as well");
            Console.WriteLine("We have to change the access modifier from public to protected in room class");
            Console.WriteLine("Composition is an interesting way to delegate responsabilities to your application");
            Console.WriteLine();
            Console.WriteLine("Well known idiom  which says \" favor composition over ihneritance\"");
            Console.WriteLine("It is an advice because word favor is used , which means you shoudl prefer");
            Console.WriteLine("Wikipedia page - Composition over inheritance");
            Console.WriteLine("We are calling implementation inheritance , not interface inheritance");
            Console.WriteLine("It says to favor composition over inheritance, is a design principle that gives the design higher flexibility");
            Console.WriteLine("It is more natural to build bussiness domain classes out of various components which means classes than trying to find commonality between them nad creating a family tree");
            Console.WriteLine("Gas pedal and a wheel share very few common traits, yet they are both vital components of a car. ");
            Console.WriteLine("Composition also provides a more stable bussiness domain in the long term as it is less prone to the quirks of the family members");
            Console.WriteLine("It is better to compose what an object can do with  \" a has a \" relationship than extend what it is with an \"is a \" relationship that you get with inheritance");
            Console.WriteLine("Interface inheritance that the initial design is simplified by identifing system object baheviours in separate interfaces instead of creating a hierarhical relationship to distribute behaviours among bussiness domain classes via inheritance");
            Console.WriteLine("This approach more easily accommodates future requiremnt changes that would otherwise require complete restructuring of the bussiness domain classes in the inheritance model");
            Console.WriteLine("Additionaly it avoids problems often associated with relatively minor changes to an inheritance based model that includes several generations of classes");
            Console.WriteLine("When it comes to inheritance , you should use it sparingly");
            Console.WriteLine("In domain context, less inheritence you use it, it is better ");
            Console.WriteLine("In application specific object than it might make sense to employ more inheritance");
            Console.WriteLine("You should prefer the simplicity of composition over inheritance");


            PressEnterForMainMenu();

        }

        public static void UndestandingAgileAnalysisAndDesignProcessUsingTeams()
        {
            Console.Clear();

            Console.WriteLine("The topic of design  and where it happens in the process of the application development life cycle");
            Console.WriteLine("The topic of the process around design , to see where it fits into a agile world");
            Console.WriteLine("We talked about the application lifecycle in regards to object orientation. We introduced the BDUF - Big design up front ");
            Console.WriteLine("We talked how BDUF was problematic and how more agile approach to design");
            Console.WriteLine("A more organic realtime approach that involves many different team members participating during the project");
            Console.WriteLine("Schedule in order to continue to discover the design as it reveals itself as new requiremnt pop up");
            Console.WriteLine("That agile methodology is a more thoughtful, low friction and sensible way of designing our object and interaction");
            Console.WriteLine("Developers are just making it up as they are going along and they are not putting a lot of forethought into it upfront");
            Console.WriteLine();
            Console.WriteLine("Truly agile approach means that there is a member of the team - domain expert , you can call him  the bussiness liaison");
            Console.WriteLine("This is somebody who sits with the development team but he represents the end users and the project sponsors and he actualy becomes part of the development team");
            Console.WriteLine("The development team and this liason are all working together to uncover and then implement the problem domain and the solution design");
            Console.WriteLine("Unified modeling language UML - defines formal artifacts like use cases along with lots of different types of diagrams ");
            Console.WriteLine("Object oriented analysis allowed for requirements documents of different sorts to be created at various points in the early stages of the application life cycle");
            Console.WriteLine("And contrasting that to the agile methodoly, agile actually defines a lightweight set of analysis and design documents but they are very lightweight");
            Console.WriteLine("And visual studio team services provides a means of mapping a requirement to individual tasks that must be completed by the developers");
            Console.WriteLine("Visual studio team services and the agile methodology allow you to keep all those things a little more tightly coupled together");
            Console.WriteLine("You can go from requirement to task management to design and implementation and tie back to original requirement");
            Console.WriteLine("Also tie it to testing and other things to kind of close all the loops and make sure that everything the customer wanted actually is being addressed");
            Console.WriteLine();
            Console.WriteLine("There are several different benefits to this");
            Console.WriteLine("Giving the entire team some confidence that the software is working according to the requirements");
            Console.WriteLine("If it does not work, entire team can pintpoint code, with unit test that did not pass the test");
            Console.WriteLine("Did not satisfy the ultimate requirement");
            Console.WriteLine();
            Console.WriteLine("Visual studio team services");
            Console.WriteLine("You can perform agile project management which include things like reports, task assignment to team members, issue tracking");
            Console.WriteLine("There is also team collaboration features");
            Console.WriteLine("Code repository, that is kkind of the entry way into using more of the functionalitiy a version of git that is hosted by Microsoft in the cloud");
            Console.WriteLine("There is continuos integration and this take the form of continuos build. So every time you do a checking into git");
            Console.WriteLine("It will automatically run all the unit test that you created against that code to make sure that it can pass those tests and actually build up and compile your software");
            Console.WriteLine("The second half of that is continuous deployment, it will automatically deploy it out to some sort of testing server so those people who are involved in integration testing  can always using the newest version");
            Console.WriteLine();
            Console.WriteLine("Backlog simply means thare is a collection of items that have yet to be started or addressed in some way");
            Console.WriteLine("This is place to define a number of features - the requirements for the new system and those are going to be added as feature that are required in the system");
            Console.WriteLine("Or they are going to wind up in a more granular format as user stories ");
            Console.WriteLine("The upper management will wind up gathering together features that habe been requested into what called epics");
            Console.WriteLine("And an epic is sort of like an initiave inside of an organization");
            Console.WriteLine("It is so big that it thansdends individual software releases. It is the highest level view of the development effort usually seen from a senior management perspective");
            Console.WriteLine();
            Console.WriteLine("Feature can be delivered in a single release of the software, and features are mapped to Epics");
            Console.WriteLine("And then features have one or more stories");
            Console.WriteLine("User story is something that can be delivered in a single sprint");
            Console.WriteLine("It is a requirement, it is a feature that is been broken down granularly and can be accomplished in one week, two weeks, whatever the duration of the sptint it is");
            Console.WriteLine("User stories in turn have usually tasks associated with them, and these are even more granular ");
            Console.WriteLine("They are individual to do items assigned to individual developers");
            Console.WriteLine("Even methods and classes are being assigned to individual developers - those are called work items as well");
            Console.WriteLine("There are different types of work items , there is a tasks, issues and bugs and feadback and so on");
            Console.WriteLine("Theme is generally implemented as something called a tag in Visual studio team servisec");
            Console.WriteLine();
            Console.WriteLine("DIAGRAM");
            Console.WriteLine("\" DEFINE STORIES, REQUREMENTS \"   * create your backlog  * Priritise your backlog  * Estimate work  * Assign work");
            Console.WriteLine("\" MANAGE PORTFOLIOS\"  * Add epics or features   * Group backlog items");
            Console.WriteLine("\" MANAGE BUGS \"  * Capture bugs  * Triage bugs  * Resolve & close bugs");
            Console.WriteLine("\"MANAGE ISSUES \" * Capture issues  *Track dependecies  * Query issues");
            Console.WriteLine();
            Console.WriteLine("It shows common workflow and it looks pretty linear , but many times these things are going on in parallel");
            Console.WriteLine();
            Console.WriteLine("User stories are created by team members at all levels");
            Console.WriteLine("They are created as the team continues to understand more and more about the requirement for the application");
            Console.WriteLine();
            Console.WriteLine("User story is basically just a simple description of what i term a happy path");
            Console.WriteLine("It is a basic coure of events required to accomplish something meaningfull in the system ");
            Console.WriteLine("It usually takes a form AS a ___ , I want to ___ so that ___");
            Console.WriteLine("There is an actor, an actions that takes place and the desired outcome");
            Console.WriteLine("Acceptance criteria ,these are the things that the system has to do in order for us as the end users to say that is good, it works like we agreed to");
            Console.WriteLine();
            Console.WriteLine("Once a task is assigned to a developer and it can be assigned a number of different ways ");
            Console.WriteLine("That the feature can be added to this iteration, but also we can see all the backlogs items that are added to iteration one");
            Console.WriteLine("In other words, these are the ones that the development team are committing to for this iteration, then in canban board we can assigne people to work on it ");
            Console.WriteLine("NEW - ACTIVE - RESOLVED - CLOSED - it is all states for this particular item, when developer is workinf on this project");
            Console.WriteLine("Everything is always up for reconsideration based on new needs reqiurements in the system that have revealed themselves");



            PressEnterForMainMenu();


        }

        public static void WhereToGoNext()
        {
            Console.Clear();

            Console.WriteLine("The goal for this course was to help you understand \"the why\" before we started really talking in detail \"How do I \" ");
            Console.WriteLine("Object oriented programming is all about agonizing over the details of delegating responsabilities and designing collaborations between objects in order to create a conceptual machine");
            Console.WriteLine("One skill is to understand the objects , you must become the object sort of thing , to understand his responsabilitis , etc");
            Console.WriteLine("Programming like an object oriented programmer ");
            Console.WriteLine("UML, class diagrams, sequence diagrams ");
            Console.WriteLine("Solid principles and patterns");
            Console.WriteLine("Domain driven design");
            Console.WriteLine("Gang of 4 - patterns");
            Console.WriteLine("Agile methodology");

            PressEnterForMainMenu();


        }

        private static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine(" ====  MENU === ");
            Console.WriteLine();
            Console.WriteLine("1. Intro ");
            Console.WriteLine("2. Establishing Crucial Metaphors");
            Console.WriteLine("3. Application Lifecycle and Object Orientation");
            Console.WriteLine("4. Big Upfront Design: Object Oriented Analysis and Design");
            Console.WriteLine("5. Agile Methodology");
            Console.WriteLine("6. The process can affect the design");
            Console.WriteLine("7. Abstraction the Real world into a domain model");
            Console.WriteLine("8. Establishing Roles and delegating resposabilities to objects");
            Console.WriteLine("9. Contact,Interfaces and Collaborations");
            Console.WriteLine("10. Collaborations and object role stereotypes");
            Console.WriteLine("11. Conditions of use and after effect guarantee");
            Console.WriteLine("12. Domain vs Application Specific object");
            Console.WriteLine("13. Components as Neighvorhoods of Objects");
            Console.WriteLine("14. Architectual layers of responsability using Objects");
            Console.WriteLine("15. Designing Objects and Interactions");
            Console.WriteLine("16. 4 Pillars of OOP - Abstaction , Encapsulation, Inheritance, Polymorhism");
            Console.WriteLine("17. Understanding relationship coupling and dependency");
            Console.WriteLine("18. Understanding relationship inversion of control , interface");
            Console.WriteLine("19. Understanding relationship Aggregation");
            Console.WriteLine("20. Undestading relationship Compositions");
            Console.WriteLine("21. Understaning the agile analisysis and design process using teams ");
            Console.WriteLine("22. Where to go from here");
            Console.WriteLine();
            Console.WriteLine("99. Napustanje programa");
            Console.WriteLine();
            Console.WriteLine("Odaberite opciju od 1 do 10 ili 99 za napustanje programa");
        }

        public static void ChooseToDisplayMainMenu()
        {
            bool displayMenu = true;

            while(displayMenu)
            {
                MainMenu();

                string userInput = Console.ReadLine();
                string filteredUserInput = userInput.Trim();

                displayMenu = UserOption(filteredUserInput);
            }
        }

        private static bool UserOption(string input)
        {
                     

            switch (input)
            {
                case "1":
                   // IntroMainPage.DisplayLession();
                    MainPage();
                    return true;

                case "2":
                    EstablishingCrucialMetaphors();
                    return true;

                case "3":
                    ApplicationLifecycleAndObjectOrientation();
                    return true;

                case "4":
                    BigUpfrontDesign();
                    return true;

                case "5":
                    AgileMethodology();
                    return true;

                case "6":
                    TheProcessCanAffectTheDesign();
                    return true;

                case "7":
                    AbstractingTheRealWorldIntoADomainModel();
                    return true;

                case "8":
                    EstablishingRolesAndDelegatingResponsabilities();
                    return true;

                case "9":
                    ContactInterfacesAndCollaboration();
                    return true;

                case "10":
                    CollaborationsAndObjectRoleStereotypes();
                    return true;

                case "11":
                    ConditionsOfUseAndAfterEffectGuarantee();
                    return true;

                case "12":
                    DomainVSApplicationSpecificObjects();
                    return true;

                case "13":
                    ComponentsAsNeighborhoodsOfOBjects();
                    return true;

                case "14":
                    ArchitectualLayersOfResposnabilityUsingObjects();
                    return true;

                case "15":
                    DesigningObjectAndInteractions();
                    return true;

                case "16":
                    ChooseToDisplayFourPillarsMenu();
                    return true;

                case "17":
                    UnderstandingRelationshipCouplingAndDependancy();
                    return true;

                case "18":
                    InversionOfControlInterface();
                    return true;

                case "19":
                    Aggregation();
                    return true;

                case "20":
                    Composition();
                    return true;

                case "21":
                    UndestandingAgileAnalysisAndDesignProcessUsingTeams();
                    return true;

                case "22":
                    WhereToGoNext();
                    return true;

                case "99":
                    ExitProgram();
                    return false;               

                default:                    
                    Console.WriteLine("Greska");
                    Console.ReadLine();
                    return true;
            }
           
        }

        public static void PressEnterForMainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("End of Lesson.  Press Enter to return to the main menu.");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.ResetColor();
            Console.ReadLine();
        }

        public static void ExitProgram()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Hvala Vam sto ste koristili nas program.");
            Console.WriteLine("Nadamo se da su Vam informacije koje ste ovde videli bile od velikog znacaja.");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.ResetColor();
            Console.ReadLine();

            Environment.Exit(0);

           
        }

        public class Lession
        {
            public int Id { get; set; }

            private string myVar;

            public string Title
            {
                get { return myVar; }
                set { 
                     if (value.Length == 0)
                    {
                        Console.WriteLine("Naziv ne sme biti prazan");
                    }
                     else
                    {
                        myVar = value;
                    }
                                   
                }
            }

            public string Content { get; set; }
            
            public Lession (int id, string title, string content)
            {
                Id = id;
                Title = title;
                Content = content;
            }


            public void DisplayLession()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("=======================================");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($" LESSION  {Id} :  {Title}");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("=======================================");
                Console.ResetColor();
                Console.WriteLine();

                Console.WriteLine(Content);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine("End of Lesson.  Press Enter to return to the main menu.");
                Console.WriteLine("-----------------------------------------------------------------");
                Console.ResetColor();
                Console.ReadLine();


            }

        }
    }
}
