<?php
error_reporting(E_ALL);

date_default_timezone_set('Europe/Budapest');

$key = "example_key";
$issued_at = time();
$expiration_time = $issued_at + (60 * 60);
$issuer = "http://localhost:80/SOP_Beadandó/Server/REST/NY4KT5";
