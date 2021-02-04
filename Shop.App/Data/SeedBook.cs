using System.Collections.Generic;
using Shop.App.DTO;

namespace Shop.App.Data
{
    public class SeedBook
    {
        public static List<BookCreating> GetData()
        {
            return new List<BookCreating>()
            {
                new BookCreating {Title="Unlocking Android",PageCount=416,ThumbnailUrl="https://s3.amazonaws.com/AKIAJC5RLADLUMVRPFDQ.book-thumb-images/ableson.jpg",
                                  ShortDescription="Unlocking Android: A Developer's Guide provides concise, hands-on instruction for the Android operating system and development tools. This book teaches important architectural concepts in a straightforward writing style and builds on this with practical and useful examples throughout.",
                                  LongDescription="Android is an open source mobile phone platform based on the Linux operating system and developed by the Open Handset Alliance, a consortium of over 30 hardware, software and telecom companies that focus on open standards for mobile devices. Led by search giant, Google, Android is designed to deliver a better and more open and cost effective mobile experience.    Unlocking Android: A Developer's Guide provides concise, hands-on instruction for the Android operating system and development tools. This book teaches important architectural concepts in a straightforward writing style and builds on this with practical and useful examples throughout. Based on his mobile development experience and his deep knowledge of the arcane Android technical documentation, the author conveys the know-how you need to develop practical applications that build upon or replace any of Androids features, however small.    Unlocking Android: A Developer's Guide prepares the reader to embrace the platform in easy-to-understand language and builds on this foundation with re-usable Java code examples. It is ideal for corporate and hobbyists alike who have an interest, or a mandate, to deliver software functionality for cell phones.    WHAT'S INSIDE:        * Android's place in the market      * Using the Eclipse environment for Android development      * The Intents - how and why they are used      * Application classes:            o Activity            o Service            o IntentReceiver       * User interface design      * Using the ContentProvider to manage data      * Persisting data with the SQLite database      * Networking examples      * Telephony applications      * Notification methods      * OpenGL, animation & multimedia      * Sample Applications  ",
                                  Isbn="1933988673"},
                new BookCreating {Title="Android in Action, Second Edition",PageCount=592,ThumbnailUrl="https://s3.amazonaws.com/AKIAJC5RLADLUMVRPFDQ.book-thumb-images/ableson2.jpg",
                                  ShortDescription="Android in Action, Second Edition is a comprehensive tutorial for Android developers. Taking you far beyond \"Hello Android,\" this fast-paced book puts you in the driver's seat as you learn important architectural concepts and implementation strategies. You'll master the SDK, build WebKit apps using HTML 5, and even learn to extend or replace Android's built-in features by building useful and intriguing examples. ",
                                  Isbn="1935182722"},
                new BookCreating {Title="Specification by Example",ThumbnailUrl="https://s3.amazonaws.com/AKIAJC5RLADLUMVRPFDQ.book-thumb-images/adzic.jpg",
                                  Isbn="1617290084"},
                new BookCreating {Title="Flex 3 in Action",PageCount=576,
                                  ThumbnailUrl="https://s3.amazonaws.com/AKIAJC5RLADLUMVRPFDQ.book-thumb-images/ahmed.jpg",
                                  Isbn="1935182420"},
                new BookCreating {Title="Collective Intelligence in Action",PageCount=425,
                                  ThumbnailUrl="https://s3.amazonaws.com/AKIAJC5RLADLUMVRPFDQ.book-thumb-images/alag.jpg",
                                  Isbn="1933988312"},
                new BookCreating {Title="Zend Framework in Action",PageCount=432,
                                  ThumbnailUrl="https://s3.amazonaws.com/AKIAJC5RLADLUMVRPFDQ.book-thumb-images/allen.jpg",
                                  ShortDescription="Zend Framework in Action is a comprehensive tutorial that shows how to use the Zend Framework to create web-based applications and web services. This book takes you on an over-the-shoulder tour of the components of the Zend Framework as you build a high quality, real-world web application.",
                                  Isbn="1933988320"},
                new BookCreating {Title="Flex on Java",PageCount=265,
                                  ThumbnailUrl="https://s3.amazonaws.com/AKIAJC5RLADLUMVRPFDQ.book-thumb-images/allmon.jpg",
                                  ShortDescription="A beautifully written book that is a must have for every Java Developer.       Ashish Kulkarni, Technical Director, E-Business Software Solutions Ltd.",
                                  Isbn="1933988797"},
            };
        }

        public static List<BookCreating> GetData2()
        {
            // new BookCreating { Title = , PageCount = ,
            //        ThumbnailUrl  = "",
            //        ShortDescription = "",
            //        LongDescription = "",
            //        Isbn = "", },
            return new List<BookCreating>()
            {
                new BookCreating {Title="Griffon in Action",PageCount=375,
                                  ThumbnailUrl="https://s3.amazonaws.com/AKIAJC5RLADLUMVRPFDQ.book-thumb-images/almiray.jpg",
                                  ShortDescription="Griffon in Action is a comprehensive tutorial written for Java developers who want a more productive approach to UI development. In this book, you'll immediately dive into Griffon. After a Griffon orientation and a quick Groovy tutorial, you'll start building examples that explore Griffon's high productivity approach to Swing development. One of the troublesome parts of Swing development is the amount of Java code that is required to get a simple application off the ground.",
                                  Isbn="1935182234"},
                new BookCreating { Title = "OSGi in Depth", PageCount = 325,
                                   ThumbnailUrl  = "https://s3.amazonaws.com/AKIAJC5RLADLUMVRPFDQ.book-thumb-images/alves.jpg",
                                   ShortDescription = "Enterprise OSGi shows a Java developer how to develop to the OSGi Service Platform Enterprise specification, an emerging Java-based technology for developing modular enterprise applications. Enterprise OSGi addresses several shortcomings of existing enterprise platforms, such as allowing the creation of better maintainable and extensible applications, and provide a simpler, easier-to-use, light-weight solution to enterprise software development.",
                                   LongDescription = "A good application framework greatly simplifies a developer's task by providing reusable code modules that solve common, tedious, or complex tasks. Writing a great framework requires an extraordinary set of skills-ranging from deep knowledge of a programming language and target platform to a crystal-clear view of the problem space where the applications to be developed using the framework will be used.    OSGi Application Frameworks shows a Java developer how to build frameworks based on the OSGi service platform. OSGi, an emerging Java-based technology for developing modular applications, is a great tool for framework building. A framework itself, OSGi allows the developer to create a more intuitive, modular framework by isolating many of the key challenges the framework developer faces.    This book begins by describing the process, principles, and tools you must master to build a custom application framework. It introduces the fundamental concepts of OSGi, and then shows you how to put OSGi to work building various types of frameworks that solve specific development problems.    OSGi is particularly useful for building frameworks that can be easily extended by developers to create domain-specific applications. This book teaches the developer to break down a problem domain into its abstractions and then use OSGi to create a modular framework solution. Along the way, the developer learns software engineering practices intrinsic to framework building that result in systems with better software qualities, such as flexibility, extensibility, and maintainability.    Author Alexandre Alves guides you through major concepts, such as the definition of programming models and modularization techniques, and complements them with samples that have real applicability using industry-proved technologies, such as Spring-DM and Equinox.",
                                   Isbn = "193518217X", },
                new BookCreating { Title = "Flexible Rails", PageCount = 592,
                                   ThumbnailUrl  = "https://s3.amazonaws.com/AKIAJC5RLADLUMVRPFDQ.book-thumb-images/armstrong.jpg",
                                   ShortDescription = "Flexible Rails created a standard to which I hold other technical books. You definitely get your money's worth.",
                                   Isbn = "1933988509", }
            };
        }

        public static List<BookCreating> GetData3()
        {
            // new BookCreating { Title = "", PageCount = ,
            //        ThumbnailUrl  = "",
            //        ShortDescription = "",
            //        LongDescription = "",
            //        Isbn = "", },
            return new List<BookCreating>()
            {
                new BookCreating { 
                    Title = "Hello! Flex 4", PageCount = 258,
                    ThumbnailUrl  = "https://s3.amazonaws.com/AKIAJC5RLADLUMVRPFDQ.book-thumb-images/armstrong3.jpg",
                    ShortDescription = "Hello! Flex 4 progresses through 26 self-contained examples selected so you can progressively master Flex. They vary from small one-page apps, to a 3D rotating haiku, to a Connect Four-like game. And in the last chapter you'll learn to build a full Flex application called SocialStalkr   a mashup that lets you follow your friends by showing their tweets on a Yahoo map.",
                    LongDescription = "With Flex 4 you can easily add color and life to your web applications by introducing dynamic user features, slick transitions, and eye-catching animations. Flex also provides powerful data handling capabilities so you can build industrial-strength applications. And it's open source, so you can get started without forking over a lot of your hard-earned cash.    We think it should be just as much fun to learn Flex as it is to use Flex. Hello! Flex 4 shows you everything you need to know to get started with Flex 4 without bogging you down in obscure detail or academic edge cases. In this entertaining, hands-on book, you'll quickly move from Hello World into the techniques you'll need to use Flex effectively.    You'll start by progressing through 26 self-contained workshop items, which include everything from small one-page examples, to a 3D rotating haiku, to building a Connect Four game. Finally, in the last chapter you'll build a full Flex application called 'SocialStalkr': an interesting mashup of Twitter and Yahoo Maps that lets you 'stalk' your friends by showing specially formatted Twitter tweets on a Yahoo map.",
                    Isbn = "1933988762", },
            };
        }
    }
}