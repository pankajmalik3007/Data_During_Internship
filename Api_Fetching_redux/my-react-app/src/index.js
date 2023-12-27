import React from 'react';

import { Provider } from 'react-redux';
import { createRoot } from 'react-dom/client';
import App from './App';
import store from './store';

const root = document.getElementById('root');
const reactRoot = createRoot(root);
reactRoot.render(
  <Provider store={store}>
    <App />
  </Provider>
);
