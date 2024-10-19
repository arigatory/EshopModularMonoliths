import React from 'react'

type Props = {
    product: any
}

export default function ProductCard({product}: Props) {
  return (
    <div className='p-20 bg-slate-100 rounded-md mb-2'>{product.name}</div>
  )
}
