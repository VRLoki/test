-- a table unique_id with id INT and default value 1, name VARCHAR(256)
CREATE TABLE IF NOT EXISTS `unique_id` (
`id` INT DEFAULT 1 UNIQUE,
`name` VARCHAR(256)
);
