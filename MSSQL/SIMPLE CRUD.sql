CREATE DATABASE school_db;
USE school_db;

CREATE TABLE students (
s_id INT PRIMARY KEY,
name VARCHAR(100),
age INT,
grade INT
);

INSERT INTO 
students values
(1,'Aniket', 22, 9);

INSERT INTO 
students values
(2,'kumar', 21, 8),
(3,'Rahul', 22, 7.5);


INSERT INTO students(s_id, name,age, grade)
values(4, 'Ravi', 25, 8);


select * from students;


update students
SET name='Anup kumar soni'
WHERE s_id = 1;

select * from students;


DELETE students
WHERE name='Rahul';


DELETE students
WHERE name='KUMAR';