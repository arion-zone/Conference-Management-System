using ConferenceManagementSystem.Data;
using Microsoft.EntityFrameworkCore;

namespace ConferenceManagementSystem.Models;

public class DbInitializer
{

    public static void Initialize(AppDbContext context)
    {
        context.Database.EnsureCreated();

        // Set M to 9 (number of records to seed)
        int M = 9;

        // Check if the database has already been seeded
        if (context.Conferences.Any() && context.Attendees.Any() && context.Organizers.Any())
        {
            return;   // DB has already been seeded
        }

        // Seed the Conferences table
        var conferences = new List<Conference>();
        for (int i = 0; i < M; i++)
        {
            conferences.Add(new Conference
            {
                Title = $"Conference {i + 1}",
                Location = $"Location {i + 1}"
            });
        }

        context.Conferences.AddRange(conferences);
        context.SaveChanges();  // Save Conferences to get their Ids

        // Seed the Attendees table
        // Seed attendees with dummy data
        var attendees = new List<Attendee>();

        for (int i = 0; i < M; i++)
        {
            attendees.Add(new Attendee
            {
                Name = $"Attendee {i + 1}",
                Email = $"attendee{i + 1}@example.com",
                Phone = $"123456789{i + 1}" // Make sure Phone is populated
            });
        }

        context.Attendees.AddRange(attendees);
        context.SaveChanges();  // Save Attendees to get their Ids

        // Seed the Organizers table
        var organizers = new List<Organizer>();
        for (int i = 0; i < M; i++)
        {
            organizers.Add(new Organizer
            {
                Name = $"Organizer {i + 1}",
                Email = $"organizer{i + 1}@example.com",
                Phone = $"123456789{i + 1}" // Make sure Phone is populated
            });
        }

        context.Organizers.AddRange(organizers);
        context.SaveChanges();  // Save Organizers to get their Ids

        // Seed the Registration table with sample data linking Attendees and Conferences
        var registrations = new List<Registration>();

        for (int i = 0; i < M; i++)
        {
            registrations.Add(new Registration
            {
                ConferenceId = conferences[i].Id,  // Assign the ID of the conference
                AttendeeId = attendees[i].Id       // Assign the ID of the attendee
            });
        }

        context.Registrations.AddRange(registrations);
        context.SaveChanges();
    }
}