<?php
header("Access-Control-Allow-Origin: http://localhost:80/SOP_Beadandó/Server/REST/");
header("Content-Type: application/json; charset=UTF-8");
header("Access-Control-Allow-Methods: POST");
header("Access-Control-Max-Age: 3600");
header("Access-Control-Allow-Headers: Content-Type, Access-Control-Allow-Headers, Authorization, X-Requested-With");

include_once('./config/database.php');
include_once('./objects/User.php');

function create() {
    $database = new Database();
    $db = $database->connect();

    $user = new User($db);

    $data = json_decode(file_get_contents("php://input"), true);

    $user->username = $data["Username"];
    $user->password = $data["Password"];

    if ($user->userExists($user->username))
        echo json_encode(array("message" => "User already exists."));
    elseif (!is_null($user->username) && !is_null($user->password) && $user->create())
        echo json_encode(array("message" => "User Successfully Created."));
    else
        echo json_encode(array("message" => "User Creation Failed."));
}
