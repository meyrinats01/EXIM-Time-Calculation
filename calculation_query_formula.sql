USE pinguinferryjasa;

-- Start Unloading Duration (START UNLOAD)
SELECT unloading_data.voyage_number, unloading_data.team_supervisor, (unloading_data.start_unloading_time - ship_data.actual_time_arrival)/60
    AS start_unload FROM unloading_data, ship_data WHERE ship_data.deleted_at = 0;

-- Unload Time Duration (UNLOAD TIME)
SELECT unloading_data.voyage_number, (unloading_data.finish_unloading_time - unloading_data.start_unloading_time)/60
    AS unload_time FROM unloading_data WHERE deleted_at = 0;

-- Start Loading Duration (START LOAD)
SELECT loading_data.voyage_number, loading_data.team_supervisor, (unloading_data.finish_unloading_time - loading_data.start_loading_time)/60
    AS start_load FROM loading_data, unloading_data WHERE loading_data.deleted_at = 0;

-- Loading Time Duration (LOAD TIME)
SELECT voyage_number, (loading_data.finish_loading_time - loading_data.start_loading_time)/60
    AS load_time FROM loading_data WHERE deleted_at = 0;

-- Stevedore time = finish loading - start loading
SELECT ship_data.vessel, (loading_data.finish_loading_time - unloading_data.start_unloading_time)/3600 AS stevedoring_time
FROM ship_data,loading_data,unloading_data;

-- ET. Turnround = ET. Departure - ET. Arrival
SELECT ship_data.vessel, (ship_data.estimate_time_departure - ship_data.estimate_time_arrival)/3600 AS estimate_turnround FROM ship_data;

-- AT. Turnround = AT. Departure - ET. Arrival
SELECT ship_data.vessel, (ship_data.actual_time_departure - ship_data.actual_time_arrival)/3600
    AS actual_turnround FROM ship_data WHERE !deleted_at OR deleted_at=0;

SELECT vessel,captain,DATE_FORMAT(FROM_UNIXTIME(ship_data.estimate_time_arrival), '%c/%e/%Y %r') AS FormattedDate
FROM ship_data WHERE deleted_at=0;

-- DRAFT SQL for Calculation Form
CREATE VIEW calculation_form AS
    SELECT
    DATE_FORMAT(FROM_UNIXTIME(ship_data.date), '%c/%e/%Y') AS day_date,
    ship_data.vessel,
    ship_data.captain,
    unloading_data.voyage_number AS import_voyage_number,
    unloading_data.team_supervisor AS import_team_supervisor,
    (unloading_data.start_unloading_time - ship_data.actual_time_arrival)/60 AS start_unload,
    (unloading_data.finish_unloading_time - unloading_data.start_unloading_time)/60 AS unload_time,
    unloading_data.quantity AS package_import,
    loading_data.voyage_number AS export_voyage_number,
    loading_data.team_supervisor AS export_team_supervisor,
    (unloading_data.finish_unloading_time - loading_data.start_loading_time)/60 AS start_load,
    (loading_data.finish_loading_time - loading_data.start_loading_time)/60 AS load_time,
    loading_data.quantity AS package_export,
    (loading_data.finish_loading_time - unloading_data.start_unloading_time)/3600 AS stevedoring_time,
    (ship_data.estimate_time_departure - ship_data.estimate_time_arrival)/3600 AS estimate_turnround,
    (ship_data.actual_time_departure - ship_data.actual_time_arrival)/3600 AS actual_turnround
FROM
    ship_data
INNER JOIN
    unloading_data ON DATE_FORMAT(FROM_UNIXTIME(ship_data.date), '%c/%e/%Y') = DATE_FORMAT(FROM_UNIXTIME(unloading_data.date), '%c/%e/%Y')
INNER JOIN
    loading_data ON DATE_FORMAT(FROM_UNIXTIME(unloading_data.date), '%c/%e/%Y') = DATE_FORMAT(FROM_UNIXTIME(loading_data.date), '%c/%e/%Y')
WHERE
    ship_data.deleted_at = 0
    AND unloading_data.deleted_at = 0
    AND loading_data.deleted_at = 0;

SELECT * FROM calculation_form WHERE day_date BETWEEN '7/23/2024 07:37:34 PM' AND '7/31/2024 07:37:34 PM';


DROP VIEW calculation_form;

SELECT
    DATE_FORMAT(FROM_UNIXTIME(ship_data.date), '%c/%e/%Y') AS day_date,
    ship_data.vessel,
    ship_data.captain,
    unloading_data.voyage_number AS import_voyage_number,
    unloading_data.team_supervisor AS import_team_supervisor,
    (unloading_data.start_unloading_time - ship_data.actual_time_arrival)/60 AS start_unload,
    (unloading_data.finish_unloading_time - unloading_data.start_unloading_time)/60 AS unload_time,
    unloading_data.quantity AS package_import,
    loading_data.voyage_number AS export_voyage_number,
    loading_data.team_supervisor AS export_team_supervisor,
    (unloading_data.finish_unloading_time - loading_data.start_loading_time)/60 AS start_load,
    (loading_data.finish_loading_time - loading_data.start_loading_time)/60 AS load_time,
    loading_data.quantity AS package_export,
    (loading_data.finish_loading_time - unloading_data.start_unloading_time)/3600 AS stevedoring_time,
    (ship_data.estimate_time_departure - ship_data.estimate_time_arrival)/3600 AS estimate_turnround,
    (ship_data.actual_time_departure - ship_data.actual_time_arrival)/3600 AS actual_turnround
FROM
    ship_data
INNER JOIN
    unloading_data ON DATE_FORMAT(FROM_UNIXTIME(ship_data.date), '%c/%e/%Y') = DATE_FORMAT(FROM_UNIXTIME(unloading_data.date), '%c/%e/%Y')
INNER JOIN
    loading_data ON DATE_FORMAT(FROM_UNIXTIME(unloading_data.date), '%c/%e/%Y') = DATE_FORMAT(FROM_UNIXTIME(loading_data.date), '%c/%e/%Y')
WHERE
    ship_data.deleted_at = 0
    AND unloading_data.deleted_at = 0
    AND loading_data.deleted_at = 0;


INSERT INTO unloading_data (date, voyage_number, start_unloading_time, finish_unloading_time, quantity, team_supervisor, created_at)
VALUES ('1720278969', 'B2272', '1720253409', '1720255269', '128', 'DEDY YUSRON', '1722439038')