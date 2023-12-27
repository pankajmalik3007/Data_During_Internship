
export const fetchDataFromAPI = async (url) => {
    try {
      const response = await fetch('https://dummyjson.com/products');
      const data = await response.json();
      return data;
    } catch (error) {
      throw error;
    }
  };
  