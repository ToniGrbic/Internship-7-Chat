using Microsoft.EntityFrameworkCore;
using ChatApp.Data.Entities.Models;

namespace ChatApp.Data.Seeds;

public static class DatabaseSeeder
{
    public static void Seed(ModelBuilder builder)
    {
        builder.Entity<Users>().HasData(
            new Users("anteAdmin@gmail.com", "123456", "AnteAdmin")
            {
                Id = 1,
                IsAdmin = true,
                IsLogged = false
            },
            new Users("tonigrbic@gmail.com", "pass123", "ToniGrbic")
            {
                Id = 2,
                IsAdmin = false,
                IsLogged = false
            },
            new Users("matematic@gmail.com", "pass123", "Matematic")
            {
                Id = 3,
                IsAdmin = false,
                IsLogged = false
            },
            new Users("anteantic1@gmail.com", "pass123", "AnteAntic1")
            {
                Id = 4,
                IsAdmin = false,
                IsLogged = false
            },
            new Users("ivoIvic@gmail.com", "pass123", "IvoIvic")
            {
                Id = 5,
                IsAdmin = false,
                IsLogged = false
            },
            new Users("anaAnjic@gmail.com", "pass123", "AnaAnjic")
            {
                Id = 6,
                IsAdmin = true,
                IsLogged = false
            },
            new Users("ivaIvic23@gmail.com", "pass123", "IvaIvic23")
            {
                Id = 7,
                IsAdmin = false,
                IsLogged = false
            },
            new Users("mateaMatic2@gmail.com", "pass123", "MateaMatic2")
            {
                Id = 8,
                IsAdmin = false,
                IsLogged = false
            },
            new Users("simesimic@gmail.com", "pass123", "SimeSimic")
            {
                Id = 9,
                IsAdmin = false,
                IsLogged = false
            },
            new Users("antonioAntic12@gmail.com", "pass123", "AntonioAntic12")
            {
                Id = 10,
                IsAdmin = false,
                IsLogged = false
            },
            new Users("josipJosipovic@gmail.com", "pass123", "JosipJosipovic")
            {
                Id = 11,
                IsAdmin = false,
                IsLogged = false
            }
        );

        builder.Entity<Groups>().HasData(
            new Groups("DUMP")
            {
                Id = 1
            },
            new Groups("fesb")
            {
                Id = 2
            },
            new Groups("pmf")
            {
                Id = 3
            },
            new Groups("family")
            {
                Id = 4
            },
            new Groups("friends")
            {
                Id = 5
            }
        );

        builder.Entity<GroupUsers>().HasData(
            new GroupUsers
            {
                GroupId = 1,
                UserId = 1
            },
            new GroupUsers
            {
                GroupId = 1,
                UserId = 2
            },
            new GroupUsers
            {
                GroupId = 1,
                UserId = 3
            },
            new GroupUsers
            {
                GroupId = 1,
                UserId = 4
            },
            new GroupUsers
            {
                GroupId = 1,
                UserId = 5
            },
            new GroupUsers
            {
                GroupId = 1,
                UserId = 6
            },
            new GroupUsers
            {
                GroupId = 1,
                UserId = 7
            },
            new GroupUsers
            {
                GroupId = 2,
                UserId = 1
            },

            new GroupUsers
            {
                GroupId = 2,
                UserId = 2
            },
            new GroupUsers
            {
                GroupId = 2,
                UserId = 3
            },
            new GroupUsers
            {
                GroupId = 2,
                UserId = 4
            },
            new GroupUsers
            {
                GroupId = 2,
                UserId = 5
            },
            new GroupUsers
            {
                GroupId = 2,
                UserId = 6
            },
            new GroupUsers
            {
                GroupId = 2,
                UserId = 7
            },
            new GroupUsers
            {
                GroupId = 3,
                UserId = 8
            },
            new GroupUsers
            {
                GroupId = 3,
                UserId = 9
            },
            new GroupUsers
            {
                GroupId = 3,
                UserId = 10
            },
            new GroupUsers
            {
                GroupId = 3,
                UserId = 11
            },
            new GroupUsers
            {
                GroupId = 4,
                UserId = 4
            },
            new GroupUsers
            {
                GroupId = 4,
                UserId = 5
            },
            new GroupUsers
            {
                GroupId = 4,
                UserId = 6
            },
            new GroupUsers
            {
                GroupId = 4,
                UserId = 7
            },
            new GroupUsers
            {
                GroupId = 5,
                UserId = 5
            },
            new GroupUsers
            {
                GroupId = 5,
                UserId = 6
            },
            new GroupUsers
            {
                GroupId = 5,
                UserId = 7
            },
            new GroupUsers
            {
                GroupId = 5,
                UserId = 8
            },
            new GroupUsers
            {
                GroupId = 5,
                UserId = 9
            },
            new GroupUsers
            {
                GroupId = 5,
                UserId = 10
            },
            new GroupUsers
            {
                GroupId = 5,
                UserId = 11
            }
        );

        builder.Entity<GroupMessages>().HasData(
            new GroupMessages("Hello everyone!")
            {
                Id = 1,
                GroupID = 1,
                SenderUserID = 1
            },
            new GroupMessages("Yo yo whats up guys?")
            {
                Id = 2,
                GroupID = 1,
                SenderUserID = 2
            },
            new GroupMessages("Merry Christmas everyone!")
            {
                Id = 3,
                GroupID = 1,
                SenderUserID = 3
            },
            new GroupMessages("Happy ne year!")
            {
                Id = 4,
                GroupID = 1,
                SenderUserID = 4
            },
            new GroupMessages("yoyoyo whatsup!")
            {
                Id = 5,
                GroupID = 1,
                SenderUserID = 5
            },
            new GroupMessages("Good, what about you?")
            {
                Id = 6,
                GroupID = 1,
                SenderUserID = 6
            },
            new GroupMessages("How is the project going?")
            {
                Id = 7,
                GroupID = 1,
                SenderUserID = 7
            },
            new GroupMessages("How is the wheather?")
            {
                Id = 8,
                GroupID = 2,
                SenderUserID = 1
            },
            new GroupMessages("Very good! its sunny.")
            {
                Id = 9,
                GroupID = 2,
                SenderUserID = 2
            },
            new GroupMessages("Happy new year everyone!")
            {
                Id = 10,
                GroupID = 2,
                SenderUserID = 3
            },
            new GroupMessages("yoyo whatsup, happy new year aswell!")
            {
                Id = 11,
                GroupID = 2,
                SenderUserID = 4
            },
            new GroupMessages("all the best in the new year everyone!")
            {
                Id = 12,
                GroupID = 2,
                SenderUserID = 5
            },
            new GroupMessages("Happy new year!")
            {
                Id = 13,
                GroupID = 2,
                SenderUserID = 6
            },
            new GroupMessages("Hello, also wishing everyone the best")
            {
                Id = 14,
                GroupID = 2,
                SenderUserID = 7
            },
            new GroupMessages("hey does anyone wanna hang out tonight?")
            {
                Id = 15,
                GroupID = 3,
                SenderUserID = 8
            },
            new GroupMessages("Sure, im free tonight!")
            {
                Id = 16,
                GroupID = 3,
                SenderUserID = 9
            },
            new GroupMessages("I cant, im busy tonight.")
            {
                Id = 17,
                GroupID = 3,
                SenderUserID = 10
            },
            new GroupMessages("I can, but im really tired today.")
            {
                Id = 18,
                GroupID = 3,
                SenderUserID = 11
            },
            new GroupMessages("yoyo whatsup everyone!")
            {
                Id = 19,
                GroupID = 4,
                SenderUserID = 4
            },
            new GroupMessages("good, what about you?")
            {
                Id = 20,
                GroupID = 4,
                SenderUserID = 5
            },
            new GroupMessages("Im fine, just working a lot lately")
            {
                Id = 21,
                GroupID = 4,
                SenderUserID = 6
            },
            new GroupMessages("Hello, im doing good")
            {
                Id = 22,
                GroupID = 4,
                SenderUserID = 7
            },
            new GroupMessages("Where would you like to travel next guys?")
            {
                Id = 23,
                GroupID = 5,
                SenderUserID = 5
            },
            new GroupMessages("I would like to go to Italy")
            {
                Id = 24,
                GroupID = 5,
                SenderUserID = 6
            },
            new GroupMessages("I would like to go to Spain")
            {
                Id = 25,
                GroupID = 5,
                SenderUserID = 7
            },
            new GroupMessages("I would like to go to France")
            {
                Id = 26,
                GroupID = 5,
                SenderUserID = 8
            },
            new GroupMessages("I would also love to go to France")
            {
                Id = 27,
                GroupID = 5,
                SenderUserID = 9
            },
            new GroupMessages("Me too!")
            {
                Id = 28,
                GroupID = 5,
                SenderUserID = 10
            },
            new GroupMessages("Then France it is?")
            {
                Id = 29,
                GroupID = 5,
                SenderUserID = 11
            },
            new GroupMessages("Helloooo!")
            {
                Id = 30,
                GroupID = 1,
                SenderUserID = 1
            },
            new GroupMessages("Hello helooo!")
            {
                Id = 31,
                GroupID = 1,
                SenderUserID = 2
            },
            new GroupMessages("Hello yoyooy!")
            {
                Id = 32,
                GroupID = 1,
                SenderUserID = 3
            },
            new GroupMessages("Hello whats upp!")
            {
                Id = 33,
                GroupID = 1,
                SenderUserID = 4
            },
            new GroupMessages("yoyoyo whatsup!")
            {
                Id = 34,
                GroupID = 1,
                SenderUserID = 5
            }
        );

        builder.Entity<PrivateMessages>().HasData(
            new PrivateMessages("Hello, how are you?")
            {
                Id = 1,
                SenderUserID = 1,
                ReceiverUserID = 2
            },
            new PrivateMessages("Im good, what about you?")
            {
                Id = 2,
                SenderUserID = 2,
                ReceiverUserID = 1
            },
            new PrivateMessages("Im good aswell, just working a lot lately")
            {
                Id = 3,
                SenderUserID = 1,
                ReceiverUserID = 2
            },
            new PrivateMessages("Hello, how are you?")
            {
                Id = 4,
                SenderUserID = 1,
                ReceiverUserID = 3
            },
            new PrivateMessages("Im good, what about you?")
            {
                Id = 5,
                SenderUserID = 3,
                ReceiverUserID = 1
            },
            new PrivateMessages("Im good aswell, just working a lot lately")
            {
                Id = 6,
                SenderUserID = 1,
                ReceiverUserID = 3
            },
            new PrivateMessages("Hello, how are you?")
            {
                Id = 7,
                SenderUserID = 1,
                ReceiverUserID = 4
            },
            new PrivateMessages("Im good, what about you?")
            {
                Id = 8,
                SenderUserID = 4,
                ReceiverUserID = 1
            },
            new PrivateMessages("Im good aswell, just working a lot lately")
            {
                Id = 9,
                SenderUserID = 1,
                ReceiverUserID = 4
            },
            new PrivateMessages("Hello, how are you?")
            {
                Id = 10,
                SenderUserID = 1,
                ReceiverUserID = 5
            },
            new PrivateMessages("Im good, what about you?")
            {
                Id = 11,
                SenderUserID = 5,
                ReceiverUserID = 1
            },
            new PrivateMessages("Im good aswell, just working a lot lately")
            {
                Id = 12,
                SenderUserID = 1,
                ReceiverUserID = 5
            },
            new PrivateMessages("Hello, how are you?")
            {
                Id = 13,
                SenderUserID = 1,
                ReceiverUserID = 6
            },
            new PrivateMessages("Im good, what about you?")
            {
                Id = 14,
                SenderUserID = 6,
                ReceiverUserID = 1
            },
            new PrivateMessages("Im good aswell, just working a lot lately")
            {
                Id = 15,
                SenderUserID = 1,
                ReceiverUserID = 6
            },
            new PrivateMessages("Hello, how are you?")
            {
                Id = 16,
                SenderUserID = 1,
                ReceiverUserID = 7
            },
            new PrivateMessages("Im good, what about you?")
            {
                Id = 17,
                SenderUserID = 7,
                ReceiverUserID = 1
            },
            new PrivateMessages("Im good aswell, just working a lot lately")
            {
                Id = 18,
                SenderUserID = 2,
                ReceiverUserID = 7
            },
            new PrivateMessages("Hello, how are you?")
            {
                Id = 19,
                SenderUserID = 2,
                ReceiverUserID = 3
            },
            new PrivateMessages("Im good, what about you?")
            {
                Id = 20,
                SenderUserID = 3,
                ReceiverUserID = 2
            },
            new PrivateMessages("Im good aswell, just working a lot lately")
            {
                Id = 21,
                SenderUserID = 2,
                ReceiverUserID = 3
            },
            new PrivateMessages("Hello, how are you?")
            {
                Id = 22,
                SenderUserID = 2,
                ReceiverUserID = 4
            },
            new PrivateMessages("Im good, what about you?")
            {
                Id = 23,
                SenderUserID = 4,
                ReceiverUserID = 2
            },
            new PrivateMessages("Im good aswell, just working a lot lately")
            {
                Id = 24,
                SenderUserID = 2,
                ReceiverUserID = 4
            },
            new PrivateMessages("Hello, how are you?")
            {
                Id = 25,
                SenderUserID = 2,
                ReceiverUserID = 5
            },
            new PrivateMessages("Im good, what about you?")
            {
                Id = 26,
                SenderUserID = 5,
                ReceiverUserID = 2
            },
            new PrivateMessages("Im good aswell, just working a lot lately")
            {
                Id = 27,
                SenderUserID = 2,
                ReceiverUserID = 5
            },
            new PrivateMessages("Hello, how are you?")
            {
                Id = 28,
                SenderUserID = 2,
                ReceiverUserID = 6
            },
            new PrivateMessages("Im good, what about you?")
            {
                Id = 29,
                SenderUserID = 6,
                ReceiverUserID = 2
            },
            new PrivateMessages("Im good aswell, just working a lot lately")
            {
                Id = 30,
                SenderUserID = 2,
                ReceiverUserID = 6
            },
            new PrivateMessages("Hello, how are you?")
            {
                Id = 31,
                SenderUserID = 2,
                ReceiverUserID = 7
            },
            new PrivateMessages("Im good, what about you?")
            {
                Id = 32,
                SenderUserID = 7,
                ReceiverUserID = 2
            },
            new PrivateMessages("Im good aswell, just working a lot lately")
            {
                Id = 33,
                SenderUserID = 2,
                ReceiverUserID = 7
            },
            new PrivateMessages("Hello, how are you?")
            {
                Id = 34,
                SenderUserID = 3,
                ReceiverUserID = 4
            },
            new PrivateMessages("Im good, what about you?")
            {
                Id = 35,
                SenderUserID = 4,
                ReceiverUserID = 3
            },
            new PrivateMessages("Im good aswell, just working a lot lately")
            {
                Id = 36,
                SenderUserID = 3,
                ReceiverUserID = 4
            },
            new PrivateMessages("Hello, how are you?")
            {
                Id = 37,
                SenderUserID = 3,
                ReceiverUserID = 5
            },
            new PrivateMessages("Im good, what about you?")
            {
                Id = 38,
                SenderUserID = 5,
                ReceiverUserID = 3
            },
            new PrivateMessages("Im good aswell, just working a lot lately")
            {
                Id = 39,
                SenderUserID = 3,
                ReceiverUserID = 5
            },
            new PrivateMessages("Hello, how are you?")
            {
                Id = 40,
                SenderUserID = 3,
                ReceiverUserID = 6
            },
            new PrivateMessages("Im good, what about you?")
            {
                Id = 41,
                SenderUserID = 6,
                ReceiverUserID = 3
            },
            new PrivateMessages("Im good aswell, just working a lot lately")
            {
                Id = 42,
                SenderUserID = 3,
                ReceiverUserID = 6
            },
            new PrivateMessages("Hello, how are you?")
            {
                Id = 43,
                SenderUserID = 3,
                ReceiverUserID = 7
            },
            new PrivateMessages("Im good, what about you?")
            {
                Id = 44,
                SenderUserID = 7,
                ReceiverUserID = 3
            },
            new PrivateMessages("Im good aswell, just working a lot lately")
            {
                Id = 45,
                SenderUserID = 3,
                ReceiverUserID = 7
            },
            new PrivateMessages("Hello, how are you?")
            {
                Id = 46,
                SenderUserID = 4,
                ReceiverUserID = 5
            },
            new PrivateMessages("Im good, what about you?")
            {
                Id = 47,
                SenderUserID = 5,
                ReceiverUserID = 4
            },
            new PrivateMessages("Im good aswell, just working a lot lately")
            {
                Id = 48,
                SenderUserID = 4,
                ReceiverUserID = 5
            },
            new PrivateMessages("Hello, how are you?")
            {
                Id = 49,
                SenderUserID = 4,
                ReceiverUserID = 6
            },
            new PrivateMessages("Im good, what about you?")
            {
                Id = 50,
                SenderUserID = 6,
                ReceiverUserID = 4
            },
            new PrivateMessages("Im good aswell, just working a lot lately")
            {
                Id = 51,
                SenderUserID = 4,
                ReceiverUserID = 6
            },
            new PrivateMessages("Hello, how are you?")
            {
                Id = 52,
                SenderUserID = 4,
                ReceiverUserID = 7
            },
            new PrivateMessages("Im good, what about you?")
            {
                Id = 53,
                SenderUserID = 7,
                ReceiverUserID = 4
            },
            new PrivateMessages("Im good aswell, just working a lot lately")
            {
                Id = 54,
                SenderUserID = 4,
                ReceiverUserID = 7
            },
            new PrivateMessages("Hello, how are you?")
            {
                Id = 55,
                SenderUserID = 5,
                ReceiverUserID = 6
            },
            new PrivateMessages("Im good, what about you?")
            {
                Id = 56,
                SenderUserID = 6,
                ReceiverUserID = 5
            },
            new PrivateMessages("Im good aswell, just working a lot lately")
            {
                Id = 57,
                SenderUserID = 5,
                ReceiverUserID = 6
            },
            new PrivateMessages("Hello, how are you?")
            {
                Id = 58,
                SenderUserID = 5,
                ReceiverUserID = 7
            },
            new PrivateMessages("Im good, what about you?")
            {
                Id = 59,
                SenderUserID = 7,
                ReceiverUserID = 5
            },
            new PrivateMessages("Im good aswell, just working a lot lately")
            {
                Id = 60,
                SenderUserID = 5,
                ReceiverUserID = 7
            },
            new PrivateMessages("Hello, how are you?")
            {
                Id = 61,
                SenderUserID = 6,
                ReceiverUserID = 7
            },
            new PrivateMessages("Im good, what about you?")
            {
                Id = 62,
                SenderUserID = 7,
                ReceiverUserID = 6
            },
            new PrivateMessages("Im good aswell, just working a lot lately")
            {
                Id = 63,
                SenderUserID = 6,
                ReceiverUserID = 7
            }
        );


    }
}