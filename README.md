# AspnetMicroservices
Simple asp.net core microservices

# Catalog MongoDb 
    Docker command : 
        docker exec -it mongo.db /bin/bash

    Connect MongoDb :
        mongo -u mongoadmin -p secret 

    Create collection:
        use CatalogDb
        db.createCollection('Products');

        db.Products.insertMany(
			[
			    {
			        "Name": "Asus Laptop",
			        "Category": "Computers",
			        "Summary": "Summary",
			        "Description": "Description",
			        "ImageFile": "ImageFile",
			        "Price": 54.93
			    },
			    {
			        "Name": "HP Laptop",
			        "Category": "Computers",
			        "Summary": "Summary",
			        "Description": "Description",
			        "ImageFile": "ImageFile",
			        "Price": 88.93
			    }
			])
            
            
        db.Products.find({}).pretty()
        db.Products.remove({})

        show databases
        show collections
        db.Products.find({}).pretty()

        #CatalogAPI List
        Method      URL
        -----       ----------------------------
        GET         api/v1/Catalog
        GET         api/v1/Catalog/{id}
        GET         api/v1/Catalog/GetProductByCategory/{category}
        POST        api/v1/Catalog
        PUT         api/v1/Catalog
        DELETE      api/v1/Catalog/{id}

# Basket Redis API
         docker pull redis
         docker run -d -p 6379:6379 --name aspnetrun-redis redis
         docker exec -it aspnetrun-redis /bin/bash

         Method      URL
        -----       ----------------------------
        GET         api/v1/Basket
        POST        api/v1/Basket
        POST        api/v1/Basket/Checkout
        DELETE      api/v1/Basket/{userName}
