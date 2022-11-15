import logo from './logo.svg';
import './App.css';
import { Fragment, useMemo, useState, ul } from 'react';

function Smth1(props){
  return <p>{props.cos}</p>;

}

function Smth2(props){
  return <p>{props.children}</p>;

}
function WlasnaLista({lista, wrapper = ul, item}){
  return(
    <wrapper>
      {lista.map(item)}
    </wrapper>
    // <ul>
    // {lista.map(it => <li>{it}</li>)}
    // </ul>
  );
}

function Example(){
  const [number, setNumber] = useState(0);
  
  return (
    <div>
      <button onClick={() => setNumber(n => n+1)}>+</button>
      <input type="number" value={number} onChange={e=>setNumber(e.target)}/>
      <button onClick={() => setNumber(n => n-1)}>-</button>
      {number <0 ? <h1>Mniejsza od 0</h1> : <></>}
    </div>
  );
}

const obj = {
  a:"b",
  b:"b"
}

const aa = {...obj,b:"c"}

const {
  b,
  ...rest
} = aa
console.log(rest);

function A(b) {}

// (b=>{})

// function(b) { return "c";}


function App() {
  const [lista, setList] = useState([])
  const h = <h2>asd</h2>;
  //const [state, setState] = useState("a");
  const [state, setState] = useState(0);
  const s = useMemo(() => state*state, [state])
  return (
      <Fragment>
        <Example>

        </Example>
        <>
          <Smth2>
          <h2>1</h2>
          <h2>2</h2>
          <h2>3</h2>
          </Smth2>
        </>
      <Smth1 cos={h}/>
      <input type="number" value={state} onChange={ e => setState(e.target.value)}/>
      {/* <input type="text" value={state} onChange={ e => setState(e.target.value)}/> */}
      {/* <input type="text"/> */}
      <button onClick={() => setList(lista => [...lista, state])}>Dodaj</button>
      <h5>{state}</h5>
      <h5>{s}</h5>
      <WlasnaLista lista={lista} wrapper={ul} item={it => <li>{it}</li>}/>
      </Fragment>
  );
}

export default App;
