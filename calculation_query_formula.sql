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

SELECT vessel,captain,DATE_FORMAT(FROM_UNIXTIME(ship_data.estimate_time_arrival), '%c/%e/%Y %r') AS FormattedDate
FROM ship_data WHERE deleted_at=0;



