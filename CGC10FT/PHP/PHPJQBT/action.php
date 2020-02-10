<?php
    require "DAL/BaseRepository.php";
    require "DAL/ProductRepository.php";
    require "Model/Product.php";
    require "Controller/ProductController.php";
    use \Controller\ProductController;
    use Model\Product;

    $controller = new ProductController();
    $page = isset($_REQUEST['page'])? $_REQUEST['page'] : NULL;
    
    switch ($page){
        case 'get':
        {
            $id = intval($_GET["id"]);
            $controller->get($id);
            break;
        }
        case 'delete':
        {
            $id = intval($_GET["id"]);
            $controller->delete($id);
            break;
        }   
        case 'save':
        {
            $data = $_GET["data"];

            $obj = json_decode($data);

            $product = new Product($obj->productName, $obj->price, $obj->description, $obj->manufactory);
            $product->id = $obj->productId;
            $controller->save($product);
            break;
        }   
        default:
        {
            $controller->gets();
            break;
        }   
    }
?>