// SubjectList component
import React from 'react';
import SubjectItem from './SubjectItem';
import ModeToggle from './ButtonChangeMode';


const SubjectList = ({ subjects }) => {
  return (
    <div>
      {subjects.map((subject) => (
        <SubjectItem key={subject.id} subject={subject} />
      ))}
    </div>
  );
};

export default SubjectList;
