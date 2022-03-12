create table Students(
studentId varchar(50) primary key,
stuName varchar(50) not null,
stuPassword varchar(50) not null
);

create table Teachers(
teacherId varchar(50) primary key,
teacherName varchar(50) not null,
teacherPassword varchar(50) not null
);

create table Course (
courseId varchar(50) primary key,
courseName varchar(50) not null,
maxAmount int not null
);

create table RegStudent (
regId int primary key,
score decimal,
studentId varchar(50),
teacherId varchar(50),
courseId varchar(50),
CONSTRAINT RegStudent_studentId_FK FOREIGN KEY (studentId) REFERENCES Students,
CONSTRAINT RegStudent_teacherId_FK FOREIGN KEY (teacherId) REFERENCES Teachers,
CONSTRAINT RegStudent_courseId_FK FOREIGN KEY (courseId) REFERENCES Course
);
