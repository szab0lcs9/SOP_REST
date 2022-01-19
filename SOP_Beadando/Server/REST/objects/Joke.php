<?php


Class Joke {
    private $conn;
    public $content;
    public $author;

    public function __construct($db) {
        $this->conn = $db;
    }

    function get_jokes() {
        $sql = "SELECT id, content, author, updated_at FROM `sop_beadando`.corny_jokes";
        $response = array();
        $stmt = $this->conn->prepare($sql);
        $stmt->execute();
        while($row = $stmt->fetchAll(PDO::FETCH_ASSOC))
            $response = $row;

        header("Content-Type: application/json; charset=UTF-8");
        echo json_encode($response);
    }


    function get_joke($id) {
        $sql = "SELECT * FROM `sop_beadando`.corny_jokes WHERE id = ? LIMIT 1";
        $response = array();
        $stmt = $this->conn->prepare($sql);
        $stmt->bindparam(1, $id);
        $stmt->execute();
        while($row = $stmt->fetch(PDO::FETCH_ASSOC))
            $response = $row;

        header("Content-Type: application/json; charset=UTF-8");
        echo json_encode($response);

    }


    function insert_joke($author) {
        $data = json_decode(file_get_contents('php://input'), true);
        $this->content = $data["Content"];
        if (!empty($data["Content"])){
            $sql = "INSERT INTO sop_beadando.corny_jokes SET content =' ".$this->content." ', author =' ".$author." '";
            $stmt = $this->conn->prepare($sql);
            if($stmt->execute())
            {
                $response=array(
                    "message" =>"Joke Added Successfully."
                );
            }
            else
            {
                $response=array(
                    "message" =>"Joke Addition Failed."
                );
            }
        }
        else
        {
            $response=array(
                "message" =>"Content cannot be empty."
            );
        }


        header("Content-Type: application/json; charset=UTF-8");
        echo json_encode($response);
    }


    function update_joke($id, $author)
    {
        $query = "SELECT * FROM `sop_beadando`.corny_jokes WHERE id = ? LIMIT 1";
        $resp = array();
        $state = $this->conn->prepare($query);
        $state->bindparam(1, $id);
        $state->execute();
        while ($row = $state->fetch(PDO::FETCH_ASSOC))
            $resp = $row;
        if ($resp != null) {
            $data = json_decode(file_get_contents('php://input'), true);
            $this->content = $data["Content"];
            $this->author = $author;
            $sql = "UPDATE sop_beadando.corny_jokes SET content =' " . $this->content . " ', author =' " . $this->author . " 'WHERE id =' " . $id . " '";
            $stmt = $this->conn->prepare($sql);
            if ($stmt->execute()) {
                $response = array(
                    "message" => "Joke Updated Successfully."
                );
            } else {
                $response = array(
                    "message" => "Joke Updation Failed."
                );
            }
            header("Content-Type: application/json; charset=UTF-8");
            echo json_encode($response);
        } else {
            $resp = array(
                "message" => "The given Id does not exist."

            );
            header("Content-Type: application/json; charset=UTF-8");
            echo json_encode($resp);
        }
   }


    function delete_joke($id)
    {
        $query = "SELECT * FROM sop_beadando.corny_jokes WHERE id = ? LIMIT 1";
        $resp = array();
        $stmt = $this->conn->prepare($query);
        $stmt->bindparam(1, $id);
        $stmt->execute();
        while ($row = $stmt->fetch(PDO::FETCH_ASSOC))
            $resp = $row;
        if ($resp != null) {
            $sql = "DELETE FROM sop_beadando.corny_jokes WHERE id =' " . $id . " '";
            $stmt = $this->conn->prepare($sql);
            if ($stmt->execute()) {
                $response = array(
                    "message" => "Joke Deleted Successfully."
                );
            } else {
                $response = array(
                    "message" => "Joke Deletion Failed."
                );
            }
            header("Content-Type: application/json; charset=UTF-8");
            echo json_encode($response);
        } else {
            $resp = array(
                "message" => "The given Id does not exist."

            );
            header("Content-Type: application/json; charset=UTF-8");
            echo json_encode($resp);
        }
    }
}