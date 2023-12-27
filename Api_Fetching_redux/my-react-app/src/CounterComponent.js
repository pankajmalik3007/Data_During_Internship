import { fetchButtonStyle, deleteButtonStyle } from './buttonStyles'; 

import React from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { addData, deleteData } from './Action/counterAction';

const CounterComponent = () => {
  const dispatch = useDispatch();
  const data = useSelector((state) => state.counter.data);

  const handleFetchData = async () => {
    try {
      const response = await fetch('https://dummyjson.com/products');
      const products = await response.json();
      dispatch(addData(products));
    } catch (error) {
      console.error('Error fetching data:', error);
    }
  };
  
  const handleDeleteData = () => {
    dispatch(deleteData());
  };

  return (
    <div>
      <button style={fetchButtonStyle} onClick={handleFetchData}>Fetch Data</button>
      <button style={deleteButtonStyle} onClick={handleDeleteData}>Delete Data</button>
      <h2>Data:</h2>
      <pre>{JSON.stringify(data, null, 2)}</pre>
    </div>
  );
};

export default CounterComponent;



