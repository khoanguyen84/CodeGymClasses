<?php
    namespace DAL;
    use Model\Product;

    class ProductRepository
    {
        public $connection;

        public function __construct($connection)
        {
            $this->connection = $connection;
        }

        public function gets()
        {
            $sql = "SELECT * FROM `product`";
            $statement = $this->connection->prepare($sql);
            $statement->execute();
            $result = $statement->fetchAll();

            $products = [];
            foreach ($result as $row) {
                $product = new Product($row["ProductName"], $row["Price"], $row["Description"], $row["Manufactory"]);
                $product->id = $row["Id"];
                $products[] = $product;
            }
            return $products;
        }

        public function get($id)
        {
            $sql = "SELECT * FROM `product` WHERE Id = ?";
            $statement = $this->connection->prepare($sql);
            $statement->bindParam(1, $id);
            $statement->execute();
            $result = $statement->fetch();

            $product = new Product($result["ProductName"], $result["Price"], $result["Description"], $result["Manufactory"]);
            $product->id = $result["Id"];
            return $product;
        }

        public function create($product)
        {
            $sql = "INSERT INTO `product`(`ProductName`, `Price`, `Description`, `Manufactory`) VALUES (?, ?, ?, ?)";
            $statement = $this->connection->prepare($sql);
            $statement->bindParam(1, $product->productName);
            $statement->bindParam(2, $product->price);
            $statement->bindParam(3, $product->description);
            $statement->bindParam(4, $product->manufactory);
            return $statement->execute();
        }

        public function update($product)
        {
            $sql = "UPDATE `product` SET `ProductName` = ?, `Price` = ?, `Description` = ?, `Manufactory` = ? WHERE `Id` = ?";
            $statement = $this->connection->prepare($sql);
            $statement->bindParam(1, $product->productName);
            $statement->bindParam(2, $product->price);
            $statement->bindParam(3, $product->description);
            $statement->bindParam(4, $product->manufactory);
            $statement->bindParam(5, $product->id);
            return $statement->execute();
        }

        public function delete($id)
        {
            $sql = "DELETE FROM `product` WHERE Id = ?";
            $statement = $this->connection->prepare($sql);
            $statement->bindParam(1, $id);
            return$statement->execute();
        }
    }
?>