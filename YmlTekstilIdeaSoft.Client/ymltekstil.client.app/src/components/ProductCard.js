import noImage from '../assets/no-image.png'
import { Button } from 'reactstrap';
import React, { Component } from 'react';

class ProductCard extends Component {

  constructor(props) {
    super(props);
    const {
      image = {}, id = {}, sku = {}, name = {}
    } = props.product.mainProduct || {};

    this.id = id;
    this.sku = sku;
    this.name = name;

    this.imagePath = noImage;

    if (props.product.mainProduct.images.length > 0) {
      this.imagePath = `http://st2.myideasoft.com/idea/hn/38/myassets/products/${id}/${props.product.mainProduct.images[0]?.filename}_min.jpeg`
    }

    this.sizes = []; // create an empty array
    this.colors = []; // create an empty array
    this.sizeColorMap = [];

    var variants = props.product.productVariants;

    variants.map(v => {
      let s = v.name.split("-")[1];
      let c = v.name.split("-")[0]

      this.sizes.push(s);

      this.sizeColorMap.push({ key: s, value: c })
    });

    this.sizes = [... new Set(this.sizes)];
    this.selectedSize = this.sizes[0];
    this.selectedColor = null;
  }

  sizeUpdated = (newSize) =>   {
    this.selectedSize = newSize
    this.colors = [... new Set(this.sizeColorMap.filter(sc => sc.key === newSize).map(x => x.value))]
    this.forceUpdate()
  }

  colorUpdated = (newColor) =>   {
    this.selectedColor = newColor
    this.forceUpdate()
  }

  render() {
    return (
      <div class="container-fluid content-row">
        <div class="row">
          <div class="col-sm-6 col-md-12 product-card">
            <div class="card h-100">
              <div className="product-card-container border-gray rounded border mx-2 my-3 d-flex flex-row align-items-center p-0 bg-light">
                <div className="h-100 position-relative border-gray border-right px-2 bg-white rounded-left">
                  <img src={this.imagePath} width="80" height="80"></img>
                </div>
                <div className="px-3">
                  <div className="container content-row">
                    <div className="row">
                      <div className="col">
                        <span className="product-name text-dark d-block font-weight-bold">{this.name}</span>
                        <span className="product-region text-secondary text-uppercase">{this.sku}</span>
                      </div>
                      <div className="col">
                        <div className="row">
                          {this.sizes.map(s => <button className={s === this.selectedSize ? "btn-primary" : "btn-secondary"} 
                                                       onClick={() => this.sizeUpdated(s)}>{s}</button>)}
                        </div>
                        <div className="row">
                          {this.colors.map(c => <button className={c === this.selectedColor ? "btn-primary" : "btn-secondary"}
                                                        onClick={() => this.colorUpdated(c)}>{c}</button>)}
                        </div>
                      </div>
                    </div>
                    <div className="row">
                      <div className="col">
                        <Button className="btn-primary" onClick={() => { alert('do stuff') }}>Sepete Ekle</Button>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>

        </div>
      </div>
    );
  }
}

export default ProductCard;
