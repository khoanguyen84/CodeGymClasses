<?php
    namespace Controller;
    use Model\Product;
    use DAL\ProductRepository;
    use DAL\BaseRepository;

    class ProductController
    {
        public $productRepository;

        public function __construct()
        {
            $connection = new BaseRepository("mysql:host=localhost;dbname=phpjqbt", "root", "");
            $this->productRepository = new ProductRepository($connection->connect());
        }

        public function gets()
        {
            $products = $this->productRepository->gets();
            echo json_encode($products);
        }

        public function get($id)
        {
            $product = $this->productRepository->get($id);
            echo json_encode($product);
        }

        public function save($product)
        {
            if($product->id == 0){
                $result = $this->productRepository->create($product);
                echo json_encode($result);
            }
            else{
                $result = $this->productRepository->update($product);
                echo json_encode($result);
            }
        }

        public function delete($id)
        {
            $product = $this->productRepository->delete($id);
            echo json_encode($product);
        }

    }
?>