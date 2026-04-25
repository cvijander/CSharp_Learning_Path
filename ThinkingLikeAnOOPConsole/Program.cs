namespace ThinkingLikeAnOOPConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
                              
           
            ChooseToDisplayMainMenu();           

        }

        public static void MainPage()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("1. Classes, Objects, Properties, Methods");
            Console.WriteLine("2. Private, Public, Static, Instance ");
            Console.WriteLine("3. Inheritance, Abstract, Intefface");
            Console.WriteLine("4. Object BASED Programming");
            Console.WriteLine();



            Console.WriteLine();
            Console.WriteLine("Object oriented programming transcend code in so much that it transcends any give programming language per se");
            Console.WriteLine();

            Console.WriteLine("OO is a mindset");
            Console.WriteLine("A philosophy which drives a way of thinking");
            Console.WriteLine("A world view about problems and solutions");
            Console.WriteLine("A path with a North star");
            Console.WriteLine("Guidance and principles on how to achieve overarching objectives");
            Console.WriteLine();


            Console.WriteLine();
            Console.WriteLine("Object-oriented programming provides a process on how to discover and implement a conceptual machine to realize that desired output.");
            Console.WriteLine("How to decompose a problem in the real world and then build some sort of abstraction in this etherial world in our minds. ");
            Console.WriteLine("Abstraction of that real world problem, and than we will build that abstraction using principles,patterns , that will actually sum up important tenants of object-oriented programming. ");
            Console.WriteLine("Then the end result is that we have designed conceptually designed machine that takes raw materials like data input from the user, and converts those into thinks like data that has been processed,mesaging, activities and so on");
            Console.WriteLine("Those will have meaning in the living world, even if that is a conceptual world like the account world");
            Console.WriteLine();


            Console.WriteLine();
            Console.WriteLine("Software dev religion");
            Console.WriteLine("In other worlds , ita age old wisdom - not a rulebook - that gives you guidance that you must apply situactionally for your specific problem domain.");

            Console.WriteLine();
            Console.WriteLine("Require devotion");
            Console.WriteLine("People devote their entire careers practicing and learning more about Object Orientation and how to apply it in a give situation");
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
        }
    }
}
