




/*
'===============================================================================
'  LinqHelper.DAO.DieuTraDiaBanBase
'===============================================================================
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using LinqHelper;
using LinqHelper.Entity;
using LinqHelper.DAO;

namespace LinqHelper.DAO
{
	public class LqDieuTraDiaBanBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqDieuTraDiaBanBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqDieuTraDiaBanEntity obj)
		{
			provider.GetTable<LqDieuTraDiaBanEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqDieuTraDiaBanEntity _obj)
		{
			var q = from obj in provider.GetTable<LqDieuTraDiaBanEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqDieuTraDiaBanEntity tmp = q.First<LqDieuTraDiaBanEntity>();
			
			tmp.IdDiaBan = _obj.IdDiaBan;
			tmp.NgayTienHanh = _obj.NgayTienHanh;
			tmp.NoiDungDieuTra = _obj.NoiDungDieuTra;
			tmp.MaRutGon = _obj.MaRutGon;
			tmp.MaTp = _obj.MaTp;
			tmp.GhiChu = _obj.GhiChu;
			tmp.IdNguoiTao = _obj.IdNguoiTao;
			tmp.NgayTao = _obj.NgayTao;
			tmp.IdNguoiCapNhat = _obj.IdNguoiCapNhat;
			tmp.NgayCapNhat = _obj.NgayCapNhat;
			tmp.NgayHetHan = _obj.NgayHetHan;
			tmp.TrangThai = _obj.TrangThai;
		}
		
		public void Delete(LqDieuTraDiaBanEntity obj)
		{
			provider.GetTable<LqDieuTraDiaBanEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqDieuTraDiaBanEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqDieuTraDiaBanEntity ob = (LqDieuTraDiaBanEntity)q.First<LqDieuTraDiaBanEntity>();
            provider.GetTable<LqDieuTraDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdDiaBan(Guid IdDiaBan)
		{
			var q = from obj in provider.GetTable<LqDieuTraDiaBanEntity>()
                    where obj.IdDiaBan == IdDiaBan
                    select obj;
					
            LqDieuTraDiaBanEntity ob = (LqDieuTraDiaBanEntity)q.First<LqDieuTraDiaBanEntity>();
            provider.GetTable<LqDieuTraDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTienHanh(DateTime NgayTienHanh)
		{
			var q = from obj in provider.GetTable<LqDieuTraDiaBanEntity>()
                    where obj.NgayTienHanh.Value == NgayTienHanh
                    select obj;
					
            LqDieuTraDiaBanEntity ob = (LqDieuTraDiaBanEntity)q.First<LqDieuTraDiaBanEntity>();
            provider.GetTable<LqDieuTraDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNoiDungDieuTra(string NoiDungDieuTra)
		{
			var q = from obj in provider.GetTable<LqDieuTraDiaBanEntity>()
                    where obj.NoiDungDieuTra == NoiDungDieuTra
                    select obj;
					
            LqDieuTraDiaBanEntity ob = (LqDieuTraDiaBanEntity)q.First<LqDieuTraDiaBanEntity>();
            provider.GetTable<LqDieuTraDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqDieuTraDiaBanEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqDieuTraDiaBanEntity ob = (LqDieuTraDiaBanEntity)q.First<LqDieuTraDiaBanEntity>();
            provider.GetTable<LqDieuTraDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqDieuTraDiaBanEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqDieuTraDiaBanEntity ob = (LqDieuTraDiaBanEntity)q.First<LqDieuTraDiaBanEntity>();
            provider.GetTable<LqDieuTraDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqDieuTraDiaBanEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqDieuTraDiaBanEntity ob = (LqDieuTraDiaBanEntity)q.First<LqDieuTraDiaBanEntity>();
            provider.GetTable<LqDieuTraDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqDieuTraDiaBanEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqDieuTraDiaBanEntity ob = (LqDieuTraDiaBanEntity)q.First<LqDieuTraDiaBanEntity>();
            provider.GetTable<LqDieuTraDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqDieuTraDiaBanEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqDieuTraDiaBanEntity ob = (LqDieuTraDiaBanEntity)q.First<LqDieuTraDiaBanEntity>();
            provider.GetTable<LqDieuTraDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqDieuTraDiaBanEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqDieuTraDiaBanEntity ob = (LqDieuTraDiaBanEntity)q.First<LqDieuTraDiaBanEntity>();
            provider.GetTable<LqDieuTraDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqDieuTraDiaBanEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqDieuTraDiaBanEntity ob = (LqDieuTraDiaBanEntity)q.First<LqDieuTraDiaBanEntity>();
            provider.GetTable<LqDieuTraDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqDieuTraDiaBanEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqDieuTraDiaBanEntity ob = (LqDieuTraDiaBanEntity)q.First<LqDieuTraDiaBanEntity>();
            provider.GetTable<LqDieuTraDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqDieuTraDiaBanEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqDieuTraDiaBanEntity ob = (LqDieuTraDiaBanEntity)q.First<LqDieuTraDiaBanEntity>();
            provider.GetTable<LqDieuTraDiaBanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqDieuTraDiaBanEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqDieuTraDiaBanEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqDieuTraDiaBanEntity>();
		}

		public List<LqDieuTraDiaBanEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqDieuTraDiaBanEntity>()
                        select obj;
            return query.ToList<LqDieuTraDiaBanEntity>();
		}
		
		
		public List<LqDieuTraDiaBanEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqDieuTraDiaBanEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqDieuTraDiaBanEntity>();
		}
		
		
		public List<LqDieuTraDiaBanEntity> SelectByIdDiaBan(Guid IdDiaBan)
		{
			var query = from obj in provider.GetTable<LqDieuTraDiaBanEntity>()
                        where obj.IdDiaBan == IdDiaBan
                        select obj;
            return query.ToList<LqDieuTraDiaBanEntity>();
		}
		
		
		public List<LqDieuTraDiaBanEntity> SelectByNgayTienHanh(DateTime NgayTienHanh)
		{
			var query = from obj in provider.GetTable<LqDieuTraDiaBanEntity>()
                        where obj.NgayTienHanh.Value == NgayTienHanh
                        select obj;
            return query.ToList<LqDieuTraDiaBanEntity>();
		}
		
		
		public List<LqDieuTraDiaBanEntity> SelectByNoiDungDieuTra(string NoiDungDieuTra)
		{
			var query = from obj in provider.GetTable<LqDieuTraDiaBanEntity>()
                        where obj.NoiDungDieuTra == NoiDungDieuTra
                        select obj;
            return query.ToList<LqDieuTraDiaBanEntity>();
		}
		
		
		public List<LqDieuTraDiaBanEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqDieuTraDiaBanEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqDieuTraDiaBanEntity>();
		}
		
		
		public List<LqDieuTraDiaBanEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqDieuTraDiaBanEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqDieuTraDiaBanEntity>();
		}
		
		
		public List<LqDieuTraDiaBanEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqDieuTraDiaBanEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqDieuTraDiaBanEntity>();
		}
		
		
		public List<LqDieuTraDiaBanEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqDieuTraDiaBanEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqDieuTraDiaBanEntity>();
		}
		
		
		public List<LqDieuTraDiaBanEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqDieuTraDiaBanEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqDieuTraDiaBanEntity>();
		}
		
		
		public List<LqDieuTraDiaBanEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqDieuTraDiaBanEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqDieuTraDiaBanEntity>();
		}
		
		
		public List<LqDieuTraDiaBanEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqDieuTraDiaBanEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqDieuTraDiaBanEntity>();
		}
		
		
		public List<LqDieuTraDiaBanEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqDieuTraDiaBanEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqDieuTraDiaBanEntity>();
		}
		
		
		public List<LqDieuTraDiaBanEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqDieuTraDiaBanEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqDieuTraDiaBanEntity>();
		}
		
		
		

	}
}
