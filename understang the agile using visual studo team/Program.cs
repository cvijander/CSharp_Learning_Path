namespace understang_the_agile_using_visual_studo_team
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

                

            Console.ReadLine();
        }
    }
}


// https://www.youtube.com/watch?v=-yIEZYYGgdY&list=PLqT8wAi-pOx7X3i6Vynm57MCwFpQWJdP9&index=24
