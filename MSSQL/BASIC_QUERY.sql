EXEC sp_databases;

use school_db;

select * from students;

select * from students where s_id = 1;

SELECT *
FROM students
ORDER BY age DESC
OFFSET 2 ROWS
FETCH NEXT 1 ROWS ONLY;


--create
CREATE TABLE departments(
d_id INT PRIMARY KEY IDENTITY(1,1),
name NVARCHAR(50) NOT NULL
);

INSERT INTO departments(name)
VALUES('CSE'),
('BCA'),
('NURSING');

--Read

SELECT *
FROM departments;

--update

UPDATE departments
SET name='Phamacy'
where d_id=2;

-- delete

DELETE departments
where d_id='3';


SELECT *
FROM students s
FULL JOIN departments d
on s.s_id = d.d_id;


SELECT *
FROM students s
RIGHT JOIN departments d
on s.s_id = d.d_id;


SELECT *
FROM students s
JOIN departments d
on s.s_id = d.d_id;



SELECT * 
FROM students;


--2nd higest age
SELECT MAX(age)
FROM students
WHERE age <(SELECT MAX(age) FROM students);


--third higest age
SELECT MAX(age)
FROM students
WHERE age <(SELECT MAX(age) FROM students
WHERE age<(SELECT MAX(age) FROM students)
);

--
SELECT age, COUNT(age) as total_student_count
FROM students
GROUP BY age;

SELECT age , count(age) as total_student
FROM students
GROUP BY age
HAVING COUNT(age)>1;


SELECT *
FROM students

SELECT *
FROM students
WHERE name like 'r%';

