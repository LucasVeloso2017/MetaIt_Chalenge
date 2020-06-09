import express from 'express'

import ProductController from './controllers/productsController'

const productController = new ProductController()

const routes = express.Router()

routes.get('/products',productController.index)

routes.post('/products',productController.create)

routes.get('/products/:id',productController.show)

routes.delete('/products/:id',productController.delete)

routes.put('/products/:id',productController.store)

export default routes;