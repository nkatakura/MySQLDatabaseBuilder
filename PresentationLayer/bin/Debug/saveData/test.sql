DROP DATABASE IF EXISTS test;
CREATE DATABASE test;
USE test;

/* *****************************************************************************
	Building table vehicle_make
* *****************************************************************************/

DROP TABLE IF EXISTS vehicle_make;
CREATE TABLE vehicle_make(
	vehicle_make_name VARCHAR(50) NOT NULL COMMENT 'The name of the make'	
	, PRIMARY KEY(vehicle_make_name)
) COMMENT 'A look-up table of available vehicle makes'
;

/* *****************************************************************************
	Building table vehicle_model
* *****************************************************************************/

DROP TABLE IF EXISTS vehicle_model;
CREATE TABLE vehicle_model(
	vehicle_make VARCHAR(50) NOT NULL COMMENT 'The make of the model'	
	,	vehicle_model_name VARCHAR(50) NOT NULL COMMENT 'The name of the model'	
	, PRIMARY KEY(vehicle_make, vehicle_model_name)
	, CONSTRAINT fk_vehicle_model_vehicle_make_vehicle_make_name
		FOREIGN KEY (vehicle_make_name) REFERENCES vehicle_make(vehicle_make_name)
) COMMENT 'A look-up table of available vehicle models for each make'
;

/* *****************************************************************************
	Building table vehicles
* *****************************************************************************/

DROP TABLE IF EXISTS vehicles;
CREATE TABLE vehicles(
	vehicle_VIN VARCHAR(50) NOT NULL COMMENT 'The vehicle''s VIN (Vehicle Identification Number)'	
	,	vehicle_make VARCHAR(50) NOT NULL COMMENT 'The vehicle''s make from the vehicle_make table'	
	,	vehicle_model VARCHAR(50) NOT NULL COMMENT 'The vehicle''s model from the vehicle_model table'	
	,	vehicle_model_year VARCHAR(50) NOT NULL COMMENT 'The vehicle''s model year'	
	,	vehicle_miles INT NOT NULL COMMENT 'The odometer reading at the time of adding the vehicle'	
	,	vehicle_release_year INT NOT NULL COMMENT 'The vehicle''s release year.  This is different from model year. as model years may be different from the year the vehicle is released.'	
	,	vehicle_purchase_price DECIMAL(20, 2) NOT NULL COMMENT 'The price. in Yen. at which the vehicle was purchased at.  Value is an INT because Yen is used in whole numbers.'	
	, PRIMARY KEY(vehicle_VIN)
	, CONSTRAINT fk_vehicles_vehicle_make_vehicle_make_name
		FOREIGN KEY (vehicle_make_name) REFERENCES vehicle_make(vehicle_make_name)
	, CONSTRAINT fk_vehicles_vehicle_model_vehicle_model_name
		FOREIGN KEY (vehicle_model_name) REFERENCES vehicle_model(vehicle_model_name)
) COMMENT 'General information for all vehicles that have been purchased.  Vehicles have not necessarily been inspected. maINTained. or imported.'
;

/* *****************************************************************************
	Building table maintenance_schedule
* *****************************************************************************/

DROP TABLE IF EXISTS maintenance_schedule;
CREATE TABLE maintenance_schedule(
	maintenance_id INT NOT NULL COMMENT 'A surrogate key for the maintenance table'	
	,	vehicle_VIN VARCHAR(50) NOT NULL COMMENT 'Foreign key for which vehicle the maintenance is scheduled for'	
	,	maintenance_DATE DATE NOT NULL COMMENT 'DATE at which the maintenance is scheduled'	
	,	maintenance_complete ENUM('Y', 'N') NOT NULL COMMENT 'Whether the maintenance has been complete or not'	
	, PRIMARY KEY(maintenance_id)
	, CONSTRAINT fk_maintenance_schedule_vehicles_vehicle_VIN
		FOREIGN KEY (vehicle_VIN) REFERENCES vehicles(vehicle_VIN)
) COMMENT 'A table of scheduled vehicle maintenances'
;

/* *****************************************************************************
	Building table import_schedule
* *****************************************************************************/

DROP TABLE IF EXISTS import_schedule;
CREATE TABLE import_schedule(
	vehicle_VIN INT NOT NULL COMMENT 'The vehicle''s VIN from the vehicles table'	
	,	import_scheduled_DATE DATE NOT NULL COMMENT 'The DATE in which the vehicle is scheduled to be imported'	
	,	import_complete_DATE DATE NULL COMMENT 'The DATE when the vehicle was imported.  A null value represents a vehicle that has not been imported yet.'	
	, PRIMARY KEY(vehicle_VIN, import_scheduled_DATE)
	, CONSTRAINT fk_import_schedule_vehicles_vehicle_VIN
		FOREIGN KEY (vehicle_VIN) REFERENCES vehicles(vehicle_VIN)
) COMMENT 'A table of scheduled imports'
;

/* *****************************************************************************
	Building table inventory
* *****************************************************************************/

DROP TABLE IF EXISTS inventory;
CREATE TABLE inventory(
	inventory_id INT NOT NULL COMMENT 'A surrogate key for the inventory records'	
	,	vehicle_VIN INT NOT NULL COMMENT 'vehicle_VIN from vehicles table'	
	,	inventory_list_price DECIMAL(20, 2) NOT NULL COMMENT 'The price at which the vehicle is listed at'	
	,	inventory_list_DATE DATE NOT NULL COMMENT 'DATE the vehicle was listed'	
	, CONSTRAINT fk_inventory_vehicles_vehicle_VIN
		FOREIGN KEY (vehicle_VIN) REFERENCES vehicles(vehicle_VIN)
) COMMENT 'A table of vehicles currently available for sale'
;

/* *****************************************************************************
	Building table potential_vehicles
* *****************************************************************************/

DROP TABLE IF EXISTS potential_vehicles;
CREATE TABLE potential_vehicles(
	potential_vehicle_VIN VARCHAR(50) NOT NULL COMMENT 'The vehicle''s VIN (Vehicle Identification Number)'	
	,	potential_vehicle_make VARCHAR(50) NOT NULL COMMENT 'The vehicle''s make'	
	,	potential_vehicle_model VARCHAR(50) NOT NULL COMMENT 'The vehicle''s model'	
	,	potential_vehicle_model_year VARCHAR(50) NOT NULL COMMENT 'The vehicle''s model year'	
	,	potential_vehicle_miles INT NOT NULL COMMENT 'The vehicle''s listed mileage'	
	,	potential_vehicle_release_year INT NOT NULL COMMENT 'The vehicle''s release year.  This is different from model year. as model years may be different from the year the vehicle is released.'	
	,	potential_vehicle_list_price DECIMAL(20, 2) NULL COMMENT 'The price the vehicle is listed at. Null value indicates the vehicle is up for bid. or does not have a list price.'	
	, PRIMARY KEY(potential_vehicle_VIN)
	, CONSTRAINT fk_potential_vehicles_vehicle_make_vehicle_make_name
		FOREIGN KEY (vehicle_make_name) REFERENCES vehicle_make(vehicle_make_name)
	, CONSTRAINT fk_potential_vehicles_vehicle_model_vehicle_model_name
		FOREIGN KEY (vehicle_model_name) REFERENCES vehicle_model(vehicle_model_name)
) COMMENT 'A table of vehicles that may be purchased in the near future'
;

/* *****************************************************************************
	Building table postal_codes
* *****************************************************************************/

DROP TABLE IF EXISTS postal_codes;
CREATE TABLE postal_codes(
	postal_code VARCHAR(50) NOT NULL COMMENT 'The postal code'	
	,	country VARCHAR(50) NOT NULL COMMENT 'The country of the postal code'	
	,	state_or_province VARCHAR(50) NOT NULL COMMENT 'The state or province of the postal code'	
	,	city_or_town VARCHAR(50) NOT NULL COMMENT 'The city or town of the postal code'	
	, PRIMARY KEY(postal_code)
) COMMENT 'A table of postal codes'
;

/* *****************************************************************************
	Building table customers
* *****************************************************************************/

DROP TABLE IF EXISTS customers;
CREATE TABLE customers(
	customer_id INT NOT NULL COMMENT 'A surrogate key for customers'	
	,	customer_first_name VARCHAR(50) NOT NULL COMMENT 'The customer''s first name'	
	,	customer_last_name VARCHAR(50) NOT NULL COMMENT 'The customer''s last name'	
	,	customer_address VARCHAR(50) NOT NULL COMMENT 'The customer''s address'	
	,	customer_postal_code VARCHAR(50) NOT NULL COMMENT 'The customer''s postal code (zip code for US addresses)'	
	,	customer_email VARCHAR(50) NOT NULL COMMENT 'The customer''s email address'	
	,	customer_phone VARCHAR(50) NOT NULL COMMENT 'The customer''s phone number'	
	, PRIMARY KEY(customer_id)
) COMMENT 'General information abou