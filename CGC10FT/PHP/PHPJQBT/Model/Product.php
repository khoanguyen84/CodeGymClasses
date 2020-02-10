<?php
    namespace Model;

    class Product
    {
        public $id;
        public $productName;
        public $price;
        public $description;
        public $manufactory;

        public function __construct($productName, $price, $description, $manufactory)
        {
            $this->productName = $productName;
            $this->price = $price;
            $this->description = $description;
            $this->manufactory = $manufactory;
        }
    }
?>