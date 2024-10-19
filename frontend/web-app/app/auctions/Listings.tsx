import React from "react";
import ProductCard from "./ProductCard";

async function getData() {
  const res = await fetch("http://localhost:5000/products");

  if (!res.ok) throw Error("Failed to fetch data");

  return res.json();
}

export default async function Listings() {
  const data = await getData();
  const products = data.products;
  return (
    <div>
      {data &&
        data.products.data.map((product: any) => (
          <ProductCard product={product} key={product.id} />
        ))}
    </div>
  );
}
