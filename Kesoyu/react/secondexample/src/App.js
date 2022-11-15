import logo from './logo.svg';
import './App.css';
import {createContext, useContext} from 'react'
import { HashRouter, Route, Routes, Link,Outlet, Navigate, useNavigate } from 'react-router-dom';

const ApplicationContext = createContext();

function Example( {name} ) {
  const appContext = useContext(ApplicationContext);

  return <h1>{name}: {""+appContext}</h1>;
}

function BodyContainer(){
  const navigate = useNavigate()

  return (
    <>
    <ul>
      {["strona1","strona2","strona3"].map(
        it => <li><Link to={it}>{it}</Link></li>
      )}
      {["strona1","strona2","strona3"].map(
        it => <li><button onClick={() => navigate(it)}>{it}</button></li>
      )}
    </ul>
    <div style={{
      backgroundColor: "gray"
    }}>
      <Outlet/>
    </div>
    </>
  );
}

function App() {
  return (
    <>
    <Example name="poza providerem"/>
      <ApplicationContext.Provider value={"ca"}>
      <Example name="w providerze"/>

      </ApplicationContext.Provider>

      <HashRouter>
        <Routes>
          <Route element={<BodyContainer/>}>
            <Route path='strona1' index element={<h1>1</h1>}/>
            <Route path='strona2' index element={<h2>2</h2>}/>
            <Route path='strona3' index element={<h3>3</h3>}/>
            <Route path='*' index element={<Navigate to="strona1"></Navigate>}/>
              
          </Route>
        </Routes>
      </HashRouter>
    </>
  );
}

export default App;
