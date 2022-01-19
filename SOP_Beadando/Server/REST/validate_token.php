<?php
header("Access-Control-Allow-Origin: http://localhost:80/SOP_Beadando/Server/REST/");
header("Content-Type: application/json; charset=UTF-8");
header("Access-Control-Allow-Methods: POST");
header("Access-Control-Max-Age: 3600");
header("Access-Control-Allow-Headers: Content-Type, Access-Control-Allow-Headers, Authorization, X-Requested-With");

include_once('config/core.php');
include_once('libs/php-jwt-main/src/ExpiredException.php');
include_once('libs/php-jwt-main/src/SignatureInvalidException.php');
include_once('libs/php-jwt-main/src/JWT.php');
include_once('libs/php-jwt-main/src/Key.php');
use Firebase\JWT\JWT;
use Firebase\JWT\Key;


function validate($jwt){
    $key = "example_key";

    //$data = json_decode(file_get_contents("php://input"));
    //$jwt = $data->jwt ?? "";

    if ($jwt) {

        try {
            $decoded = JWT::decode($jwt, new Key($key, 'HS256'));
            echo json_encode(array(
                "message" => "Token status: OK.",
                "data" => $decoded->data
            ));
            return $decoded->data;
        } catch (Exception $e) {
            echo json_encode(array(
                "message" => "Token status: Wrong token.",
                "error" => $e->getMessage()
            ));
            return null;
        }
    } else {
        echo json_encode(array("message" => "Access denied."));
        return null;
    }
}