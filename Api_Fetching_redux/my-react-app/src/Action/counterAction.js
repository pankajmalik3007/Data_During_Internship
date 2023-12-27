
export const ADD_DATA = 'ADD_DATA';
export const DELETE_DATA = 'DELETE_DATA';

export const addData = (newData) => ({
  type: ADD_DATA,
  payload: Array.isArray(newData) ? newData : [newData]
});

export const deleteData = () => ({
  type: DELETE_DATA
});
