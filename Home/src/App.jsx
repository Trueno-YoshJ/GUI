import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'
import { HashRouter as Router,Routes,Route} from 'react-router-dom'
import { Home } from './Pages/home'
import { Page1 } from './Pages/Page1'
import { Layout } from './Layout'
import { Contact } from './Pages/Contact'

function App() {

  return (
    <Router>
      <Routes>
        <Route element = {<Layout/>}>
          <Route path = "/" element = {<Home/>}/>
          <Route path = "/page1" element = {<Page1/>}/>
          <Route path = "/page2" element = {<Contact/>}/>
        </Route>
      </Routes>
    </Router>
  )
}

export default App
