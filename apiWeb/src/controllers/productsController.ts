import knex from '../database/conection'
import {Request, Response} from 'express'


class ProductsController {

    async create(req:Request,res:Response){
        const {
            name,
            description,
            price
        } = req.body

        const product ={
            name,
            description,
            price
        }
        
        await knex('products').insert(product)

        return res.json({
            ...product
        })
    }

    async index(req:Request,res:Response){

        const products = await knex('products').select('*') 

        return res.json({
            products
        })

    }

    async show(req:Request,res:Response){

        const { id } = req.params

        const product = await knex('products')
        .where('id',id).first()

        if(!product){
            return res.status(400).json({message:'product not found'})
        }

        return res.json({
            product
        })

    }

    async delete(req:Request,res:Response){
        const { id } = req.params

        const product = await knex('products')
        .where('id',id).first().delete()

        if(!product){
            return res.status(400).json({message:'product not found'})
        }

        return res.json({
            product
        })

    }
    async store(req:Request,res:Response){
        const { id } = req.params

        const {
            name,
            description,
            price
        } = req.body

        const products = await knex('products')
        .where('id',id).first().update({
            name,
            description,
            price
        })

        if(!products){
            return res.status(400).json({message:'product not found'})
        }

        return res.json({
            products
        })
    }



}
export default ProductsController