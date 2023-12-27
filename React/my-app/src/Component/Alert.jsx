import React from 'react'

class Alert extends React.Component {
    showAlert() {
        let a = 10;
        let b = 20;
        let c = a + b;
        alert(`The result of ${a} + ${b} is: ${c}`);
    }
  
    render() {
      return (
        <div>
          <h2>Operation In Alert</h2>
          <button onClick={() => this.showAlert()}>Show Alert</button>
        </div>
      );
    }
  }
  export default Alert;
