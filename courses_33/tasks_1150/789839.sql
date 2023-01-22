SELECT
    MIN(`station_id`)
  FROM `temperature_august` AS `t1`
  WHERE
    `t1`.`highest` = (
        SELECT
            MIN(`highest`)
          FROM `temperature_august` AS `t2`
          WHERE `t1`.`prefecture` = `t2`.`prefecture`)
    GROUP BY `prefecture`;



SELECT
    *
  FROM
    `temperature_august`
  WHERE `station_id` IN (
    SELECT
        MIN(`station_id`)
    FROM `temperature_august` AS `t1`
    WHERE
        `t1`.`highest` = (
            SELECT
                MIN(`highest`)
            FROM `temperature_august` AS `t2`
            WHERE `t1`.`prefecture` = `t2`.`prefecture`)
        GROUP BY `t1`.`prefecture`
  )
  ORDER BY
    `highest`, `station_id`;