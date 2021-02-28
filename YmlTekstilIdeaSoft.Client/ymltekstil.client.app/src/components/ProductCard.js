import React from 'react';
import noImage from '../assets/no-image.png'

const ProductCard = props => {
  const {
    image = {}, id = {}, sku = {}, name = {}
  } = props.product || {};

  let imagePath = noImage;

  if(props.product.images.length > 0)
  {
    imagePath = `http://st2.myideasoft.com/idea/hn/38/myassets/products/${id}/${props.product.images[0]?.filename}_min.jpeg`
  }

  return (
    <div className="col-sm-6 col-md-4 product-card">
      <div className="product-card-container border-gray rounded border mx-2 my-3 d-flex flex-row align-items-center p-0 bg-light">
        <div className="h-100 position-relative border-gray border-right px-2 bg-white rounded-left">
          <img src={imagePath} width="80" height="80"></img>
        </div>
        <div className="px-3">
          <span className="product-name text-dark d-block font-weight-bold">{ name }</span>
          <span className="product-region text-secondary text-uppercase">{ sku }</span>
        </div>
      </div>
    </div>
  )
}

export default ProductCard;