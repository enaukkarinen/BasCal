USE [HarkkaprojektiDB]
GO

INSERT INTO [User] (UserID, UserName)
VALUES (NEWID(), 'Anthony Anderson'), (NEWID(), 'Woody Harrelson'), 
(NEWID(), 'Matthew McConaughey'), (NEWID(), 'Jordan Peele')

INSERT INTO[EventType] (Name) VALUES
('Unspecified'), ('General'), ('Work')

INSERT INTO[Event] (EventId, TypeId, Name, Summary, Location, StartTime, EndTime)
VALUES (NEWID(), 2, 'BasCal -project review', 'This is a summary of the event', 'Pori, Meeting Room 5',
'20140516 14:30:00', '20140516 15:00:00'),(NEWID(), 2, 'Workgroup meeting', 'This is the meeting summary.', 'Pori, Meeting Room 8',
'20140522 10:15:00', '20140522 12:00:00'),(NEWID(), 0, 'Mystery meeting', 'This is the meeting summary.', 'Pori, Meeting Room 8',
'20140516 15:15:00', '20140516 15:16:00'),(NEWID(), 1, 'Basketball', 'Remember to brings the new shoes!', 'Vähärauma',
'20140516 20:00:00', '20140522 22:00:00')