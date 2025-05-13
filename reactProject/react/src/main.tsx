import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import './index.css'
import App from './App.tsx'
import { BrowserRouter } from 'react-router'
import { Routes } from 'react-router'
import { Route } from 'react-router'
import { Menu } from './components/menu.component.tsx'
import {SubProducer} from './components/subProducer.component.tsx'
import { Verification } from './components/Verification.component.tsx'
import { AddProducer } from './components/addProucer.component.tsx'
import { Producer } from './components/producer.component.tsx'
import { ProducerType } from './types/producer.ts'
import { ShowEventOfProducer } from './components/showEventOfProducer.component.tsx'
import { User } from './components/user.component.tsx'
import { ShowEvent } from './components/showEvent.component.tsx'
import { ProducerDetails } from './components/producerDetails.component.tsx'

createRoot(document.getElementById('root')!).render(
  <StrictMode>
    <BrowserRouter>
        <Menu/>
        <Routes>
          <Route path="/" element={<App/>}/>
          <Route path="/producer/:email" element={<Producer/>} />
          <Route path="/producerDetails/:email" element={<ProducerDetails/>} />
          <Route path="/subProducer" element={<SubProducer/>} />
          <Route path="/verification" element={<Verification/>} />
          <Route path="/addProducer" element={<AddProducer/>} />
          <Route path="/user" element={<User/>}/>
          <Route path="/eventOfProducer/:id" element={<ShowEventOfProducer/>} />
          <Route path="/event/:id" element={<ShowEvent/>} />
        </Routes>
    </BrowserRouter>
  </StrictMode>,
)
