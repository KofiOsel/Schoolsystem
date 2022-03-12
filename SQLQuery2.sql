create table RegStudent (
regId int primary key,
studentId varchar(50),
courseId varchar(50),
score decimal,
CONSTRAINT RegStudent_studentId_FK FOREIGN KEY (studentId) REFERENCES Students,
CONSTRAINT RegStudent_courseId_FK FOREIGN KEY (courseId) REFERENCES Course
);

create table RegTeacher (
regId int primary key,
teacherId varchar(50),
courseId varchar(50),
CONSTRAINT RegTeacher_teacherId_FK FOREIGN KEY (teacherId) REFERENCES Teachers,
CONSTRAINT RegTeacher_courseId_FK FOREIGN KEY (courseId) REFERENCES Course
);