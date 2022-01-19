<?php
header("Access-Control-Allow-Origin: http://localhost:80/SOP_Beadando/Server/REST/");
header("Content-Type: application/json; charset=UTF-8");
header("Access-Control-Allow-Methods: POST");
header("Access-Control-Max-Age: 3600");
header("Access-Control-Allow-Headers: Content-Type, Access-Control-Allow-Headers, Authorization, X-Requested-With");

include_once('config/core.php');
include_once('config/database.php');
include_once('objects/User.php');
include_once('libs/php-jwt-main/src/BeforeValidException.php');
include_once('libs/php-jwt-main/src/ExpiredException.php');
include_once('libs/php-jwt-main/src/SignatureInvalidException.php');
include_once('libs/php-jwt-main/src/JWT.php');
use Firebase\JWT\JWT;

function login(){
    $database = new Database();
    $db = $database->connect();

    $user = new User($db);
    $data = json_decode(file_get_contents("php://input"), true);

    $user->username = $data["Username"];
    $user_exists = $user->userExists($user->username);

    $key = "example_key";
    $issued_at = time();
    $expiration_time = $issued_at + (60 * 60);
    $issuer = "http://localhost:80/SOP_Beadando/Server/REST/NY4KT5";

    if ($user_exists && password_verify($data["Password"], $user->password)) {

        $token = array(
            "iat" => $issued_at,
            "exp" => $expiration_time,
            "iss" => $issuer,
            "data" => array(
                "id" => $user->id,
                "username" => $user->username
            )
        );

        $jwt = JWT::encode($token, $key, 'HS256');
        echo json_encode(
            array(
                "message" => "Successful login.",
                "jwt" => $jwt
            )
        );
        return $jwt;
    } else {
        echo json_encode(array("message" => "Login failed. Please insert a valid Username!"));
        return null;
    }
}