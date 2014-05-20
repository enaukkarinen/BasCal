USE [HarkkaprojektiDB]
GO

INSERT INTO [User] (UserID, UserName)
VALUES (NEWID(), 'Anthony Anderson'), (NEWID(), 'Woody Harrelson'), 
(NEWID(), 'Matthew McConaughey'), (NEWID(), 'Jordan Peele')

INSERT INTO[EventType] (TypeId, Name) VALUES
(0, 'Unspecified'), (1, 'General'), (2, 'Work')

INSERT INTO[Event] (EventId, TypeId, Name, Summary, Location, StartTime, EndTime)
VALUES 
(NEWID(), 2, 'BasCal -project review', 'This is a summary of the event', 'Pori, Meeting Room 5',
'20140516 14:30:00', '20140516 15:00:00'),
(NEWID(), 2, 'Workgroup meeting', 'This is the meeting summary.', 'Pori, Meeting Room 8',
'20140522 10:15:00', '20140522 12:00:00'),
(NEWID(), 0, 'Mystery meeting', 'This is the meeting summary.', 'Pori, Meeting Room 8',
'20140516 15:15:00', '20140516 15:16:00'),
(NEWID(), 1, 'Basketball', 'Remember to brings the new shoes!', 'Vähärauma',
'20140516 20:00:00', '20140522 22:00:00')

INSERT INTO[Event] (EventId, TypeId, Name, Summary, Location, StartTime, EndTime)
VALUES 
(NEWID(), 2, 'Team meeting', 'Everyone has to attend', 'Nahkis',
'20140520 10:00:00', '20140516 11:00:00'),
(NEWID(), 1, 'Gym', 'The usual routine', 'SAMK gym',
'20140502 7:15:00', '20140502 9:00:00'),
(NEWID(), 1, 'NBA Lottery', '', 'Livingroom couch',
'20140521 2:00:00', '20140521 3:00:00'),
(NEWID(), 1, 'Tennis', 'Just dont lose!', 'Isomäki',
'20140512 20:00:00', '20140512 22:00:00')

INSERT INTO[Event] (EventId, TypeId, Name, Summary, Location, StartTime, EndTime)
VALUES 
(NEWID(), 2, 'Harkkaprojekti', 'BasCal-sovellus', '',
'20140502 9:00:00', '20140531 16:00:00')