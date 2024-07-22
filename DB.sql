USE YardManagement;
-- Table for Yard Data
CREATE TABLE YardData (
    yard_id VARCHAR(10) NOT NULL,
    location_row INT NOT NULL,
    position INT NOT NULL,
    status VARCHAR(10) NOT NULL,
    occup_status VARCHAR(10) NOT NULL,
    coil_id INT NOT NULL,
    location_id VARCHAR(15) NOT NULL,
    PRIMARY KEY (yard_id, location_row, position)
);
 CREATE TABLE user_info (
	sl INT PRIMARY KEY NOT NULL,
    user_id INT NOT NULL,
    password VARCHAR(10)
 );
 SELECT * FROM yarddata;
 SELECT * FROM user_info;

