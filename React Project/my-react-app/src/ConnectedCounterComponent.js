import React from 'react';
import { useDispatch, useSelector } from 'react-redux';
import './styles.css';
import { increment, decrement, reset } from './Action/counterActions';

const CounterComponent = () => {
  const dispatch = useDispatch();
  const count = useSelector(state => state.count);

  return (
    <div className="counter-container"> 
      <p>Clicked: {count} Amount</p>
      <button className="button increment" onClick={() => dispatch(increment())}>
        Increment
      </button>
      <button className="button decrement" onClick={() => dispatch(decrement())}>
        Decrement
      </button>
      <button className="button reset" onClick={() => dispatch(reset())}>
        Reset
      </button>
    </div>
  );
};

export default CounterComponent;
