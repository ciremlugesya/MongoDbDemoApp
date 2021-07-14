using System;

namespace MongoDbApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoCrud db = new MongoCrud("AddressBook");

            /* 1 - insert record */
            //var person = new PersonModel
            //{
            //    FirstName = "Joe",
            //    LastName = "Smith",
            //    PrimaryAddress = new AddressModel
            //    {
            //        StreetAddress = "101 Oak Street",
            //        City = "Scranton",
            //        State = "Pa",
            //        ZipCode = "2113"
            //    }
            //};

            //db.InsertRecord("Users", person);

            /* 2 - get records */
            //var records = db.LoadRecords<PersonModel>("Users");

            //foreach (var record in records)
            //{
            //    Console.WriteLine($"{record.Id}: {record.FirstName} {record.LastName}");
            //    if (record.PrimaryAddress != null)
            //    {
            //        Console.WriteLine(record.PrimaryAddress.City);
            //    }
            //}

            ///* 3 - get record by id */
            var record = db.LoadRecordById<PersonModel>("Users", new Guid("df45cbb3-796e-4e86-a25f-629a72d9af73"));

            /* 4 - upsert record */

            //record.DateOfBirth = new DateTime(1988, 4, 25, 0, 0, 0, DateTimeKind.Utc);

            //db.UpsertRecord("Users", record.Id, record);

            /* 5 - Delete record */

            db.DeleteRecord<PersonModel>("Users", record.Id);

            Console.ReadLine();
        }
    }


}
